namespace Presentation
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            bttnGoToCategory = new Button();
            bttnGoToProduct = new Button();
            bttnGoToCustomer = new Button();
            bttnGoToOrder = new Button();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // bttnGoToCategory
            // 
            bttnGoToCategory.BackColor = Color.FromArgb(224, 224, 224);
            bttnGoToCategory.FlatStyle = FlatStyle.Popup;
            bttnGoToCategory.ForeColor = Color.FromArgb(0, 0, 192);
            bttnGoToCategory.Location = new Point(405, 155);
            bttnGoToCategory.Name = "bttnGoToCategory";
            bttnGoToCategory.Size = new Size(344, 48);
            bttnGoToCategory.TabIndex = 6;
            bttnGoToCategory.Text = "Category";
            bttnGoToCategory.TextImageRelation = TextImageRelation.TextAboveImage;
            bttnGoToCategory.UseVisualStyleBackColor = false;
            bttnGoToCategory.Click += bttnGoToCategory_Click;
            // 
            // bttnGoToProduct
            // 
            bttnGoToProduct.BackColor = Color.FromArgb(0, 0, 192);
            bttnGoToProduct.FlatStyle = FlatStyle.Popup;
            bttnGoToProduct.ForeColor = Color.White;
            bttnGoToProduct.Location = new Point(405, 69);
            bttnGoToProduct.Name = "bttnGoToProduct";
            bttnGoToProduct.Size = new Size(344, 48);
            bttnGoToProduct.TabIndex = 7;
            bttnGoToProduct.Text = "Product";
            bttnGoToProduct.UseVisualStyleBackColor = false;
            bttnGoToProduct.Click += bttnGoToProduct_Click;
            // 
            // bttnGoToCustomer
            // 
            bttnGoToCustomer.BackColor = Color.FromArgb(224, 224, 224);
            bttnGoToCustomer.FlatStyle = FlatStyle.Popup;
            bttnGoToCustomer.ForeColor = Color.FromArgb(0, 0, 192);
            bttnGoToCustomer.Location = new Point(405, 339);
            bttnGoToCustomer.Name = "bttnGoToCustomer";
            bttnGoToCustomer.Size = new Size(344, 48);
            bttnGoToCustomer.TabIndex = 6;
            bttnGoToCustomer.Text = "Customers Details";
            bttnGoToCustomer.TextImageRelation = TextImageRelation.TextAboveImage;
            bttnGoToCustomer.UseVisualStyleBackColor = false;
            bttnGoToCustomer.Click += bttnGoToCustomer_Click;
            // 
            // bttnGoToOrder
            // 
            bttnGoToOrder.BackColor = Color.FromArgb(0, 0, 192);
            bttnGoToOrder.FlatStyle = FlatStyle.Popup;
            bttnGoToOrder.ForeColor = Color.White;
            bttnGoToOrder.Location = new Point(405, 246);
            bttnGoToOrder.Name = "bttnGoToOrder";
            bttnGoToOrder.Size = new Size(344, 48);
            bttnGoToOrder.TabIndex = 7;
            bttnGoToOrder.Text = "Last Orders";
            bttnGoToOrder.UseVisualStyleBackColor = false;
            bttnGoToOrder.Click += bttnGoToOrder_Click;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(39, 119);
            Logo.Name = "Logo";
            Logo.Size = new Size(327, 225);
            Logo.TabIndex = 15;
            Logo.TabStop = false;
            // 
            // AdminInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Logo);
            Controls.Add(bttnGoToCustomer);
            Controls.Add(bttnGoToCategory);
            Controls.Add(bttnGoToOrder);
            Controls.Add(bttnGoToProduct);
            Name = "AdminInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Controller";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bttnGoToCategory;
        private Button bttnGoToProduct;
        private Button bttnGoToCustomer;
        private Button bttnGoToOrder;
        private PictureBox Logo;
    }
}
