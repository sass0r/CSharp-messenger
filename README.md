# CSharp-messenger 💬

> A simple Client-Server messenger application built with C#.

![C#](https://img.shields.io/badge/C%23-.NET-239120?style=flat&logo=csharp)
![WinForms](https://img.shields.io/badge/UI-WinForms-5C2D91?style=flat)
![SQLite](https://img.shields.io/badge/Database-SQLite-003B57?style=flat&logo=sqlite)
![License](https://img.shields.io/github/license/sass0r/CSharp-messenger?style=flat)

## 📋 About

**CSharp-messenger** is a lightweight messaging application demonstrating client-server architecture in C#. It consists of:

- 🖥️ **Client**: Desktop application built with **Windows Forms** for user communication.
- 🌐 **Server**: Web API backend (ASP.NET) handling requests and message routing.
- 🗄️ **Database**: **SQLite** for persistent storage of users and chat history.

## 🚀 Tech Stack

| Component | Technologies |
|-----------|-------------|
| **Language** | C# (.NET) |
| **Client UI** | Windows Forms |
| **Server** | ASP.NET Core / Web API |
| **Database** | SQLite + ADO.NET |
| **IDE** | Visual Studio 2022+ |

## 📁 Project Structure

```
CSharp-messenger
┣ clientWinFormsApp1 # WinForms client application
┃ ┣ Program.cs # Client entry point
┃ ┗ MainForm.cs # Main chat interface
┣ serverWebApplication1 # Server-side Web API
┃ ┣ Program.cs # Server entry point
┃ ┗ Controllers/ # API endpoint controllers
┣ DB # Database & utilities
┃ ┣ messenger.db # SQLite database file
┃ ┗ SQLITE/ # Drivers & SQL scripts
┣ LICENSE # MIT License
┗ README.md # Project documentation
```


## ⚙️ Getting Started

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- Visual Studio 2022 with ".NET desktop development" workload

### 1. Clone the repository
```bash
git clone https://github.com/sass0r/CSharp-messenger.git
cd CSharp-messenger
```

### 2. Run the Server
```
cd serverWebApplication1
# Open the solution in Visual Studio and press F5
# Or run via CLI:
dotnet run --project serverWebApplication1.csproj
```
Server will be available at: http://localhost:5000 (port may vary)

### 3. Run the Client
```
# In a new terminal window
cd clientWinFormsApp1
dotnet run --project clientWinFormsApp1.csproj
# Or open the .slnx file in Visual Studio
```

4. Database Setup (Optional)
Database file is located in /DB/messenger.db
Use DB Browser for SQLite to inspect or modify data
✨ Features
- User registration & authentication
- Real-time text messaging
- Chat history persistence
- Connection status indicators
- File sharing (planned)
- Group chats (planned)
⚠️ Note: This project is under active development. Some features may be incomplete.
