namespace clientWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nickname = new TextBox();
            label1 = new Label();
            Message = new TextBox();
            Send = new Button();
            Messages = new ListBox();
            Setnickname = new Button();
            AllUsers = new ListBox();
            label2 = new Label();
            statusText = new Label();
            SuspendLayout();
            // 
            // Nickname
            // 
            Nickname.Location = new Point(80, 12);
            Nickname.Name = "Nickname";
            Nickname.Size = new Size(147, 23);
            Nickname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "nickname:";
            // 
            // Message
            // 
            Message.Location = new Point(12, 415);
            Message.Name = "Message";
            Message.Size = new Size(729, 23);
            Message.TabIndex = 2;
            // 
            // Send
            // 
            Send.Location = new Point(747, 415);
            Send.Name = "Send";
            Send.Size = new Size(41, 23);
            Send.TabIndex = 3;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Messages
            // 
            Messages.FormattingEnabled = true;
            Messages.Location = new Point(126, 41);
            Messages.Name = "Messages";
            Messages.Size = new Size(662, 364);
            Messages.TabIndex = 4;
            // 
            // Setnickname
            // 
            Setnickname.Location = new Point(233, 12);
            Setnickname.Name = "Setnickname";
            Setnickname.Size = new Size(31, 23);
            Setnickname.TabIndex = 5;
            Setnickname.Text = "set";
            Setnickname.UseVisualStyleBackColor = true;
            Setnickname.Click += Setnickname_Click;
            // 
            // AllUsers
            // 
            AllUsers.FormattingEnabled = true;
            AllUsers.Location = new Point(12, 56);
            AllUsers.Name = "AllUsers";
            AllUsers.Size = new Size(108, 349);
            AllUsers.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "online users:";
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Location = new Point(747, 20);
            statusText.Name = "statusText";
            statusText.Size = new Size(0, 15);
            statusText.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusText);
            Controls.Add(label2);
            Controls.Add(AllUsers);
            Controls.Add(Setnickname);
            Controls.Add(Messages);
            Controls.Add(Send);
            Controls.Add(Message);
            Controls.Add(label1);
            Controls.Add(Nickname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nickname;
        private Label label1;
        private TextBox Message;
        private Button Send;
        private ListBox Messages;
        private Button Setnickname;
        private ListBox AllUsers;
        private Label label2;
        private Label statusText;
    }
}
