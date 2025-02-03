namespace PresentationFinal
{
    partial class AdminCategory
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
            bttnDeleteCat = new Button();
            bttnShowAllCat = new Button();
            bttnAddCat = new Button();
            bttnEditCat = new Button();
            bttnUpdateCat = new Button();
            comboCatID = new ComboBox();
            label5 = new Label();
            txtCatDesc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtCatName = new TextBox();
            lblProName = new Label();
            lblSelectCat = new Label();
            lblProID = new Label();
            picCatDate = new DateTimePicker();
            comCatName = new ComboBox();
            SuspendLayout();
            // 
            // bttnDeleteCat
            // 
            bttnDeleteCat.BackColor = Color.Black;
            bttnDeleteCat.ForeColor = Color.Red;
            bttnDeleteCat.Location = new Point(580, 195);
            bttnDeleteCat.Name = "bttnDeleteCat";
            bttnDeleteCat.Size = new Size(151, 63);
            bttnDeleteCat.TabIndex = 17;
            bttnDeleteCat.Text = "Delete";
            bttnDeleteCat.UseVisualStyleBackColor = false;
            bttnDeleteCat.Click += bttnDeleteCat_Click;
            // 
            // bttnShowAllCat
            // 
            bttnShowAllCat.BackColor = SystemColors.ButtonFace;
            bttnShowAllCat.ForeColor = Color.FromArgb(0, 192, 0);
            bttnShowAllCat.Location = new Point(580, 363);
            bttnShowAllCat.Name = "bttnShowAllCat";
            bttnShowAllCat.Size = new Size(151, 63);
            bttnShowAllCat.TabIndex = 18;
            bttnShowAllCat.Text = "Show All";
            bttnShowAllCat.UseVisualStyleBackColor = false;
            bttnShowAllCat.Click += bttnShowAll_Click;
            // 
            // bttnAddCat
            // 
            bttnAddCat.BackColor = SystemColors.ButtonFace;
            bttnAddCat.ForeColor = Color.FromArgb(0, 192, 0);
            bttnAddCat.Location = new Point(580, 277);
            bttnAddCat.Name = "bttnAddCat";
            bttnAddCat.Size = new Size(151, 63);
            bttnAddCat.TabIndex = 19;
            bttnAddCat.Text = "Add";
            bttnAddCat.UseVisualStyleBackColor = false;
            bttnAddCat.Click += bttnAddCat_Click;
            // 
            // bttnEditCat
            // 
            bttnEditCat.BackColor = SystemColors.ButtonFace;
            bttnEditCat.ForeColor = Color.FromArgb(0, 192, 0);
            bttnEditCat.Location = new Point(580, 25);
            bttnEditCat.Name = "bttnEditCat";
            bttnEditCat.Size = new Size(151, 63);
            bttnEditCat.TabIndex = 20;
            bttnEditCat.Text = "Edit";
            bttnEditCat.UseVisualStyleBackColor = false;
            bttnEditCat.Click += bttnEditCat_Click;
            // 
            // bttnUpdateCat
            // 
            bttnUpdateCat.BackColor = SystemColors.ButtonFace;
            bttnUpdateCat.ForeColor = Color.FromArgb(0, 192, 0);
            bttnUpdateCat.Location = new Point(580, 110);
            bttnUpdateCat.Name = "bttnUpdateCat";
            bttnUpdateCat.Size = new Size(151, 63);
            bttnUpdateCat.TabIndex = 21;
            bttnUpdateCat.Text = "Update";
            bttnUpdateCat.UseVisualStyleBackColor = false;
            bttnUpdateCat.Click += bttnUpdateCat_Click;
            // 
            // comboCatID
            // 
            comboCatID.FormattingEnabled = true;
            comboCatID.Location = new Point(220, 60);
            comboCatID.Name = "comboCatID";
            comboCatID.Size = new Size(193, 28);
            comboCatID.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 334);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 6;
            label5.Text = "Created Date";
            // 
            // txtCatDesc
            // 
            txtCatDesc.Location = new Point(220, 266);
            txtCatDesc.Name = "txtCatDesc";
            txtCatDesc.Size = new Size(263, 27);
            txtCatDesc.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 266);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 195);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 8;
            label3.Text = "Select By Name";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(220, 128);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(263, 27);
            txtCatName.TabIndex = 15;
            // 
            // lblProName
            // 
            lblProName.AutoSize = true;
            lblProName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProName.Location = new Point(69, 128);
            lblProName.Name = "lblProName";
            lblProName.Size = new Size(136, 25);
            lblProName.TabIndex = 9;
            lblProName.Text = "Category Name";
            // 
            // lblSelectCat
            // 
            lblSelectCat.AutoSize = true;
            lblSelectCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectCat.Location = new Point(419, 63);
            lblSelectCat.Name = "lblSelectCat";
            lblSelectCat.Size = new Size(209, 20);
            lblSelectCat.TabIndex = 10;
            lblSelectCat.Text = "Select ID To Update Or Delete";
            // 
            // lblProID
            // 
            lblProID.AutoSize = true;
            lblProID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProID.Location = new Point(69, 61);
            lblProID.Name = "lblProID";
            lblProID.Size = new Size(107, 25);
            lblProID.TabIndex = 11;
            lblProID.Text = "Category ID";
            // 
            // picCatDate
            // 
            picCatDate.Location = new Point(220, 332);
            picCatDate.Name = "picCatDate";
            picCatDate.Size = new Size(263, 27);
            picCatDate.TabIndex = 22;
            // 
            // comCatName
            // 
            comCatName.FormattingEnabled = true;
            comCatName.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comCatName.Location = new Point(220, 196);
            comCatName.Name = "comCatName";
            comCatName.Size = new Size(263, 28);
            comCatName.TabIndex = 23;
            // 
            // AdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comCatName);
            Controls.Add(picCatDate);
            Controls.Add(bttnDeleteCat);
            Controls.Add(bttnShowAllCat);
            Controls.Add(bttnAddCat);
            Controls.Add(bttnEditCat);
            Controls.Add(bttnUpdateCat);
            Controls.Add(comboCatID);
            Controls.Add(label5);
            Controls.Add(txtCatDesc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCatName);
            Controls.Add(lblProName);
            Controls.Add(lblSelectCat);
            Controls.Add(lblProID);
            Name = "AdminCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCategory";
            Load += AdminCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnDeleteCat;
        private Button bttnShowAllCat;
        private Button bttnAddCat;
        private Button bttnEditCat;
        private Button bttnUpdateCat;
        private ComboBox comboCatID;
        private Label label5;
        private TextBox txtCatDesc;
        private Label label4;
        private Label label3;
        private TextBox txtCatName;
        private Label lblProName;
        private Label lblSelectCat;
        private Label lblProID;
        private DateTimePicker picCatDate;
        private ComboBox comCatName;
    }
}