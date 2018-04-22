namespace ResidentialLife
{
    partial class Package
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
            this.txt_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pout = new System.Windows.Forms.DateTimePicker();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.txt_perishable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(165, 18);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 21);
            this.txt_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentId";
            // 
            // txt_pin
            // 
            this.txt_pin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_pin.CustomFormat = "yyyy-MM-dd";
            this.txt_pin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_pin.Location = new System.Drawing.Point(165, 106);
            this.txt_pin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(231, 20);
            this.txt_pin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PackageDateIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PackageDateOut";
            // 
            // txt_pout
            // 
            this.txt_pout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_pout.CustomFormat = "yyyy-MM-dd";
            this.txt_pout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_pout.Location = new System.Drawing.Point(165, 154);
            this.txt_pout.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pout.Name = "txt_pout";
            this.txt_pout.Size = new System.Drawing.Size(231, 20);
            this.txt_pout.TabIndex = 5;
            this.txt_pout.Value = new System.DateTime(2017, 11, 23, 12, 5, 0, 0);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(18, 206);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(242, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(601, 206);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(244, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(294, 206);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(256, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(537, 206);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(750, 18);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 38);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txt_perishable
            // 
            this.txt_perishable.FormattingEnabled = true;
            this.txt_perishable.Items.AddRange(new object[] {
            "Perishable",
            "Not Perishable"});
            this.txt_perishable.Location = new System.Drawing.Point(165, 59);
            this.txt_perishable.Margin = new System.Windows.Forms.Padding(2);
            this.txt_perishable.Name = "txt_perishable";
            this.txt_perishable.Size = new System.Drawing.Size(120, 21);
            this.txt_perishable.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Perishable";
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_perishable);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_pout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Package";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_pout;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox txt_perishable;
        private System.Windows.Forms.Label label4;
    }
}