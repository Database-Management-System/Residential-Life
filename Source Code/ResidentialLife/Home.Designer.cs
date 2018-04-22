namespace ResidentialLife
{
    partial class Home
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
            this.Resident = new System.Windows.Forms.Button();
            this.GuestLog = new System.Windows.Forms.Button();
            this.Package = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.Equipment = new System.Windows.Forms.Button();
            this.Cafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resident
            // 
            this.Resident.Location = new System.Drawing.Point(575, 43);
            this.Resident.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resident.Name = "Resident";
            this.Resident.Size = new System.Drawing.Size(283, 49);
            this.Resident.TabIndex = 0;
            this.Resident.Text = "Resident";
            this.Resident.UseVisualStyleBackColor = true;
            this.Resident.Click += new System.EventHandler(this.Resident_Click);
            // 
            // GuestLog
            // 
            this.GuestLog.Location = new System.Drawing.Point(575, 134);
            this.GuestLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuestLog.Name = "GuestLog";
            this.GuestLog.Size = new System.Drawing.Size(283, 49);
            this.GuestLog.TabIndex = 1;
            this.GuestLog.Text = "GuestLog";
            this.GuestLog.UseVisualStyleBackColor = true;
            this.GuestLog.Click += new System.EventHandler(this.GuestLog_Click);
            // 
            // Package
            // 
            this.Package.Location = new System.Drawing.Point(575, 223);
            this.Package.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Package.Name = "Package";
            this.Package.Size = new System.Drawing.Size(283, 49);
            this.Package.TabIndex = 2;
            this.Package.Text = "Package";
            this.Package.UseVisualStyleBackColor = true;
            this.Package.Click += new System.EventHandler(this.Package_Click);
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(575, 318);
            this.Stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(283, 49);
            this.Stock.TabIndex = 3;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // Equipment
            // 
            this.Equipment.Location = new System.Drawing.Point(575, 411);
            this.Equipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(283, 49);
            this.Equipment.TabIndex = 4;
            this.Equipment.Text = "Equipment";
            this.Equipment.UseVisualStyleBackColor = true;
            this.Equipment.Click += new System.EventHandler(this.Equipment_Click);
            // 
            // Cafe
            // 
            this.Cafe.Location = new System.Drawing.Point(575, 503);
            this.Cafe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(283, 49);
            this.Cafe.TabIndex = 5;
            this.Cafe.Text = "Cafe";
            this.Cafe.UseVisualStyleBackColor = true;
            this.Cafe.Click += new System.EventHandler(this.Cafe_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.Cafe);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Package);
            this.Controls.Add(this.GuestLog);
            this.Controls.Add(this.Resident);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Resident;
        private System.Windows.Forms.Button GuestLog;
        private System.Windows.Forms.Button Package;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button Equipment;
        private System.Windows.Forms.Button Cafe;
    }
}