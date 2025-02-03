namespace PresentationFinal
{
    partial class AdminProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProduct));
            lblProID = new Label();
            lblProName = new Label();
            txtProName = new TextBox();
            label3 = new Label();
            txtProPrice = new TextBox();
            label4 = new Label();
            txtProInStock = new TextBox();
            label5 = new Label();
            comboProID = new ComboBox();
            bttnDelete = new Button();
            bttnAdd = new Button();
            bttnUpdate = new Button();
            bttnShowAll = new Button();
            bttnEdit = new Button();
            lblSelect = new Label();
            txtCategoryName = new TextBox();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // lblProID
            // 
            lblProID.AutoSize = true;
            lblProID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProID.Location = new Point(41, 63);
            lblProID.Name = "lblProID";
            lblProID.Size = new Size(97, 25);
            lblProID.TabIndex = 0;
            lblProID.Text = "Product ID";
            // 
            // lblProName
            // 
            lblProName.AutoSize = true;
            lblProName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProName.Location = new Point(41, 130);
            lblProName.Name = "lblProName";
            lblProName.Size = new Size(126, 25);
            lblProName.TabIndex = 0;
            lblProName.Text = "Product Name";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(192, 130);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(193, 27);
            txtProName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 197);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 0;
            label3.Text = "Unit Price";
            // 
            // txtProPrice
            // 
            txtProPrice.Location = new Point(192, 197);
            txtProPrice.Name = "txtProPrice";
            txtProPrice.Size = new Size(193, 27);
            txtProPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 268);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 0;
            label4.Text = "Units In Stock";
            // 
            // txtProInStock
            // 
            txtProInStock.Location = new Point(192, 268);
            txtProInStock.Name = "txtProInStock";
            txtProInStock.Size = new Size(193, 27);
            txtProInStock.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 336);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 0;
            label5.Text = "Category";
            // 
            // comboProID
            // 
            comboProID.FormattingEnabled = true;
            comboProID.Location = new Point(192, 62);
            comboProID.Name = "comboProID";
            comboProID.Size = new Size(193, 28);
            comboProID.TabIndex = 2;
            // 
            // bttnDelete
            // 
            bttnDelete.BackColor = Color.Black;
            bttnDelete.ForeColor = Color.Red;
            bttnDelete.Location = new Point(552, 197);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(151, 63);
            bttnDelete.TabIndex = 3;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = false;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // bttnAdd
            // 
            bttnAdd.BackColor = SystemColors.ButtonFace;
            bttnAdd.ForeColor = Color.FromArgb(0, 192, 0);
            bttnAdd.Location = new Point(552, 279);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(151, 63);
            bttnAdd.TabIndex = 4;
            bttnAdd.Text = "Add";
            bttnAdd.UseVisualStyleBackColor = false;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // bttnUpdate
            // 
            bttnUpdate.BackColor = SystemColors.ButtonFace;
            bttnUpdate.ForeColor = Color.FromArgb(0, 192, 0);
            bttnUpdate.Location = new Point(552, 112);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(151, 63);
            bttnUpdate.TabIndex = 5;
            bttnUpdate.Text = "Update";
            bttnUpdate.UseVisualStyleBackColor = false;
            bttnUpdate.Click += bttnUpdate_Click;
            // 
            // bttnShowAll
            // 
            bttnShowAll.BackColor = SystemColors.ButtonFace;
            bttnShowAll.ForeColor = Color.FromArgb(0, 192, 0);
            bttnShowAll.Location = new Point(552, 365);
            bttnShowAll.Name = "bttnShowAll";
            bttnShowAll.Size = new Size(151, 63);
            bttnShowAll.TabIndex = 4;
            bttnShowAll.Text = "Show All";
            bttnShowAll.UseVisualStyleBackColor = false;
            bttnShowAll.Click += bttnShowAll_Click;
            // 
            // bttnEdit
            // 
            bttnEdit.BackColor = SystemColors.ButtonFace;
            bttnEdit.ForeColor = Color.FromArgb(0, 192, 0);
            bttnEdit.Location = new Point(552, 27);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(151, 63);
            bttnEdit.TabIndex = 5;
            bttnEdit.Text = "Edit";
            bttnEdit.UseVisualStyleBackColor = false;
            bttnEdit.Click += bttnEdit_Click;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelect.Location = new Point(391, 65);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(209, 20);
            lblSelect.TabIndex = 0;
            lblSelect.Text = "Select ID To Update Or Delete";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(192, 337);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(193, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(391, 204);
            Logo.Name = "Logo";
            Logo.Size = new Size(143, 91);
            Logo.TabIndex = 14;
            Logo.TabStop = false;
            // 
            // AdminProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnDelete);
            Controls.Add(bttnShowAll);
            Controls.Add(bttnAdd);
            Controls.Add(bttnEdit);
            Controls.Add(bttnUpdate);
            Controls.Add(comboProID);
            Controls.Add(label5);
            Controls.Add(txtCategoryName);
            Controls.Add(txtProInStock);
            Controls.Add(label4);
            Controls.Add(txtProPrice);
            Controls.Add(label3);
            Controls.Add(txtProName);
            Controls.Add(lblProName);
            Controls.Add(lblSelect);
            Controls.Add(lblProID);
            Controls.Add(Logo);
            Name = "AdminProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Product";
            Load += AdminProduct_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProID;
        private Label lblProName;
        private TextBox txtProName;
        private Label label3;
        private TextBox txtProPrice;
        private Label label4;
        private TextBox txtProInStock;
        private Label label5;
        private ComboBox comboProID;
        private Button bttnDelete;
        private Button bttnAdd;
        private Button bttnUpdate;
        private Button bttnShowAll;
        private Button bttnEdit;
        private Label lblSelect;
        private TextBox txtCategoryName;
        private PictureBox Logo;
    }
}