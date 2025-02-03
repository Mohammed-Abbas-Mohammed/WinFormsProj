namespace PresentationFinal
{
    partial class CustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            CustomerGridView = new DataGridView();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // CustomerGridView
            // 
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGridView.Dock = DockStyle.Fill;
            CustomerGridView.Location = new Point(0, 0);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.RowHeadersWidth = 51;
            CustomerGridView.Size = new Size(1313, 624);
            CustomerGridView.TabIndex = 2;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(1208, 552);
            Logo.Name = "Logo";
            Logo.Size = new Size(105, 72);
            Logo.TabIndex = 17;
            Logo.TabStop = false;
            // 
            // CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 624);
            Controls.Add(Logo);
            Controls.Add(CustomerGridView);
            Name = "CustomerDetails";
            Text = "CustomerDetails";
            Load += CustomerDetails_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CustomerGridView;
        private PictureBox Logo;
    }
}