namespace ResidentialLife
{
    partial class Equipment
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
            this.txt_ein = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_eout = new System.Windows.Forms.DateTimePicker();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.txt_damaged = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_avail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(165, 17);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(117, 21);
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
            // txt_ein
            // 
            this.txt_ein.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_ein.CustomFormat = "yyyy-MM-dd HH:mm";
            this.txt_ein.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ein.Location = new System.Drawing.Point(531, 67);
            this.txt_ein.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ein.Name = "txt_ein";
            this.txt_ein.Size = new System.Drawing.Size(149, 20);
            this.txt_ein.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(416, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "EquipmentIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(416, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "EquipmentOut";
            // 
            // txt_eout
            // 
            this.txt_eout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_eout.CustomFormat = "yyyy-MM-dd HH:mm";
            this.txt_eout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_eout.Location = new System.Drawing.Point(531, 19);
            this.txt_eout.Margin = new System.Windows.Forms.Padding(2);
            this.txt_eout.Name = "txt_eout";
            this.txt_eout.Size = new System.Drawing.Size(149, 20);
            this.txt_eout.TabIndex = 5;
            this.txt_eout.Value = new System.DateTime(2017, 11, 23, 12, 5, 0, 0);
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
            this.dataGridView1.Location = new System.Drawing.Point(77, 244);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(663, 174);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(750, 19);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 38);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txt_damaged
            // 
            this.txt_damaged.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.txt_damaged.FormattingEnabled = true;
            this.txt_damaged.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.txt_damaged.Location = new System.Drawing.Point(531, 109);
            this.txt_damaged.Margin = new System.Windows.Forms.Padding(2);
            this.txt_damaged.Name = "txt_damaged";
            this.txt_damaged.Size = new System.Drawing.Size(117, 21);
            this.txt_damaged.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(416, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Damaged";
            // 
            // txt_iname
            // 
            this.txt_iname.FormattingEnabled = true;
            this.txt_iname.Location = new System.Drawing.Point(165, 60);
            this.txt_iname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(117, 21);
            this.txt_iname.TabIndex = 15;
            this.txt_iname.SelectedIndexChanged += new System.EventHandler(this.txt_iname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ItemName";
            // 
            // txt_avail
            // 
            this.txt_avail.Location = new System.Drawing.Point(165, 105);
            this.txt_avail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_avail.Name = "txt_avail";
            this.txt_avail.Size = new System.Drawing.Size(117, 20);
            this.txt_avail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(21, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Availability";
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_avail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_damaged);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_eout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ein);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_ein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_eout;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox txt_damaged;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_iname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_avail;
        private System.Windows.Forms.Label label6;
    }
}