using Microsoft.AspNetCore.SignalR.Client;

namespace clientWinFormsApp1
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        string nickname;

        public Form1()
        {
            InitializeComponent();
            Initconnection();
        }

        private async void Initconnection()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7018/chat")
                .Build();

            connection.On<string>("Error", (error) =>
            {
                MessageBox.Show(error);
            });

            connection.On<string, string>("Receive", (user, message) =>
            {
                Messages.Invoke(new Action(() => { Messages.Items.Add($"{user}: {message}"); }));
            });

            connection.On<string, string>("GetOldMessages", (user, message) =>
            {
                Messages.Invoke(new Action(() => { Messages.Items.Add($"{user}: {message}"); }));
            });

            connection.On<string>("GetNewUsers", (user) =>
            {
                AllUsers.Invoke(new Action(() => { AllUsers.Items.Add(user); }));
            });

            connection.On<string>("RemoveNewUsers", (user) =>
            {
                AllUsers.Invoke(new Action(() => { AllUsers.Items.Remove(user); }));
            });

            try 
            { 
                await connection.StartAsync();
                statusText.Text = "Online";
                statusText.ForeColor = Color.Green;

                await connection.InvokeAsync("OldMessages");
                await connection.InvokeAsync("RegisterNewConnection");
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                statusText.ForeColor = Color.Black;
                statusText.Text = "Offline";
            }            
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            await connection.InvokeAsync("Send", nickname, Message.Text);
            Message.Clear();
        }

        private async void Setnickname_Click(object sender, EventArgs e)
        {
            nickname = Nickname.Text;

            await connection.InvokeAsync("RegisterUser", nickname);

            Setnickname.Enabled = false;
        }
    }
}
