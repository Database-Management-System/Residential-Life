namespace ResidentialLife
{
    partial class Cafe
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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.txt_iname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_avail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(110, 14);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(101, 21);
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
            this.btn_Delete.Location = new System.Drawing.Point(284, 206);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(244, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(337, 177);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(433, 19);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 38);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txt_iname
            // 
            this.txt_iname.FormattingEnabled = true;
            this.txt_iname.Location = new System.Drawing.Point(110, 55);
            this.txt_iname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(101, 21);
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
            this.txt_avail.Location = new System.Drawing.Point(110, 101);
            this.txt_avail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_avail.Name = "txt_avail";
            this.txt_avail.Size = new System.Drawing.Size(101, 20);
            this.txt_avail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(21, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Availability";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(110, 144);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(101, 20);
            this.txt_price.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price";
            // 
            // Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_avail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox txt_iname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_avail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label2;
    }
}