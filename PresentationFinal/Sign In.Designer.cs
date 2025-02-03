namespace T11_12
{
    partial class Sign_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In));
            txtUserName = new TextBox();
            txtPass = new TextBox();
            bttnSignAdmin = new Button();
            button1 = new Button();
            bttnUser = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(367, 109);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(344, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(367, 176);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(344, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // bttnSignAdmin
            // 
            bttnSignAdmin.BackColor = Color.Cyan;
            bttnSignAdmin.FlatStyle = FlatStyle.Popup;
            bttnSignAdmin.ForeColor = Color.Red;
            bttnSignAdmin.Location = new Point(367, 238);
            bttnSignAdmin.Name = "bttnSignAdmin";
            bttnSignAdmin.Size = new Size(344, 48);
            bttnSignAdmin.TabIndex = 5;
            bttnSignAdmin.Text = "Sign In";
            bttnSignAdmin.UseVisualStyleBackColor = false;
            bttnSignAdmin.Click += bttnSign_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(367, 43);
            button1.Name = "button1";
            button1.Size = new Size(344, 48);
            button1.TabIndex = 5;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += bttnSign_Click;
            // 
            // bttnUser
            // 
            bttnUser.ForeColor = Color.Blue;
            bttnUser.Location = new Point(370, 368);
            bttnUser.Name = "bttnUser";
            bttnUser.Size = new Size(330, 48);
            bttnUser.TabIndex = 6;
            bttnUser.Text = "User";
            bttnUser.UseVisualStyleBackColor = true;
            bttnUser.Click += bttnUser_Click;
            // 
            // Sign_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnUser);
            Controls.Add(button1);
            Controls.Add(bttnSignAdmin);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Name = "Sign_In";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button bttnSignAdmin;
        private Button button1;
        private Button bttnUser;
    }
}