namespace Categoryy.FForm
{
    partial class CustomerInsertion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInsertion));
            textBox1 = new TextBox();
            firstbox = new TextBox();
            lastbox = new TextBox();
            phonebox = new TextBox();
            countrybox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            addresbox = new TextBox();
            mailbox = new TextBox();
            bttnSub = new Button();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Teal;
            textBox1.Location = new Point(55, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 40);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter Your Information :";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // firstbox
            // 
            firstbox.BackColor = SystemColors.Window;
            firstbox.Location = new Point(143, 78);
            firstbox.Name = "firstbox";
            firstbox.Size = new Size(287, 29);
            firstbox.TabIndex = 1;
            // 
            // lastbox
            // 
            lastbox.Location = new Point(143, 131);
            lastbox.Name = "lastbox";
            lastbox.Size = new Size(287, 29);
            lastbox.TabIndex = 2;
            // 
            // phonebox
            // 
            phonebox.Location = new Point(143, 183);
            phonebox.Name = "phonebox";
            phonebox.Size = new Size(287, 29);
            phonebox.TabIndex = 3;
            // 
            // countrybox
            // 
            countrybox.Location = new Point(143, 235);
            countrybox.Name = "countrybox";
            countrybox.Size = new Size(287, 29);
            countrybox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(33, 79);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 5;
            label1.Text = "First-Name :";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(33, 134);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 6;
            label2.Text = "Last-Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 186);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 7;
            label3.Text = "Phone-No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 239);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 8;
            label4.Text = "Country :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 360);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 9;
            label5.Text = "E-Mail :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 298);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 10;
            label6.Text = " Address :";
            // 
            // addresbox
            // 
            addresbox.Location = new Point(143, 295);
            addresbox.Name = "addresbox";
            addresbox.Size = new Size(287, 29);
            addresbox.TabIndex = 11;
            // 
            // mailbox
            // 
            mailbox.Location = new Point(143, 357);
            mailbox.Name = "mailbox";
            mailbox.Size = new Size(287, 29);
            mailbox.TabIndex = 12;
            // 
            // bttnSub
            // 
            bttnSub.BackColor = SystemColors.ControlLightLight;
            bttnSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnSub.ForeColor = Color.LightSeaGreen;
            bttnSub.Location = new Point(531, 335);
            bttnSub.Name = "bttnSub";
            bttnSub.Size = new Size(161, 48);
            bttnSub.TabIndex = 20;
            bttnSub.Text = "Submit";
            bttnSub.UseVisualStyleBackColor = false;
            bttnSub.Click += bttnSub_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(501, 79);
            Logo.Name = "Logo";
            Logo.Size = new Size(232, 153);
            Logo.TabIndex = 21;
            Logo.TabStop = false;
            // 
            // CustomerInsertion
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(Logo);
            Controls.Add(bttnSub);
            Controls.Add(mailbox);
            Controls.Add(addresbox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countrybox);
            Controls.Add(phonebox);
            Controls.Add(lastbox);
            Controls.Add(firstbox);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkCyan;
            Name = "CustomerInsertion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerInsert";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox firstbox;
        private TextBox lastbox;
        private TextBox phonebox;
        private TextBox countrybox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox addresbox;
        private TextBox mailbox;
        private Button bttnSub;
        private PictureBox Logo;
    }
}