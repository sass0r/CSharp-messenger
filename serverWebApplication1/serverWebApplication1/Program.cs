using Microsoft.AspNetCore.SignalR;
using SignalRApp;
using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Information);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/", () => "SignalR is running.");
app.MapHub<ChatHub>("/chat");

app.Run();

namespace SignalRApp
{
    public class ChatHub : Hub
    {
        SqliteConnection dbconnection;

        private readonly ILogger<ChatHub> _logger;

        public ChatHub(ILogger<ChatHub> logger)
        {
            _logger = logger;
        }

        public async Task Send(string user, string message)
        {
            _logger.LogInformation($"{user}: {message}");

            await Clients.All.SendAsync("Receive", user, message);

            using (dbconnection = new SqliteConnection("Data Source=messenger_messages.db"))
            {
                dbconnection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = dbconnection;
                command.CommandText = $"CREATE TABLE IF NOT EXISTS \"messages\" " +
                    $"(\r\n\t\"ID\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"user\"\tTEXT NOT NULL,\r\n\t\"message\"\tTEXT NOT NULL," +
                    $"\r\n\tPRIMARY KEY(\"ID\" AUTOINCREMENT)\r\n);" +
                    $"INSERT INTO messages (user, message) VALUES ('{user}', '{message}')";
                command.ExecuteNonQuery();

                dbconnection.Close();
            }
        }

        public async Task OldMessages()
        {
            using (dbconnection = new SqliteConnection("Data Source=messenger_messages.db"))
            {
                dbconnection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = dbconnection;
                command.CommandText = "SELECT user, message FROM messages";
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string user = reader.GetString(0);
                    string message = reader.GetString(1);
                    await Clients.Caller.SendAsync("GetOldMessages", user, message);
                }
                dbconnection.Close();
            }
        }
    }
}