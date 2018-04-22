namespace ResidentialLife
{
    partial class Resident
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Phoneno = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.txt_hall = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PhoneNo";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(103, 33);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(164, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Phoneno
            // 
            this.txt_Phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phoneno.Location = new System.Drawing.Point(103, 69);
            this.txt_Phoneno.Name = "txt_Phoneno";
            this.txt_Phoneno.Size = new System.Drawing.Size(164, 22);
            this.txt_Phoneno.TabIndex = 3;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(64, 238);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(242, 23);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 308);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(343, 238);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(256, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(651, 238);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(244, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(103, 103);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(164, 20);
            this.txt_email.TabIndex = 8;
            // 
            // txt_room
            // 
            this.txt_room.Location = new System.Drawing.Point(427, 103);
            this.txt_room.Margin = new System.Windows.Forms.Padding(2);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(164, 20);
            this.txt_room.TabIndex = 11;
            // 
            // txt_hall
            // 
            this.txt_hall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hall.Location = new System.Drawing.Point(427, 69);
            this.txt_hall.Name = "txt_hall";
            this.txt_hall.Size = new System.Drawing.Size(164, 22);
            this.txt_hall.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "RoomNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dob";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hall";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(427, 136);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(99, 22);
            this.txt_balance.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(427, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 22);
            this.txt_id.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "StudentID";
            // 
            // txt_dob
            // 
            this.txt_dob.CustomFormat = "yyyy-MM-dd";
            this.txt_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_dob.Location = new System.Drawing.Point(103, 138);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(164, 20);
            this.txt_dob.TabIndex = 22;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Items.AddRange(new object[] {
            "F",
            "M",
            "O"});
            this.txt_gender.Location = new System.Drawing.Point(103, 181);
            this.txt_gender.Margin = new System.Windows.Forms.Padding(2);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(99, 21);
            this.txt_gender.TabIndex = 23;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(799, 25);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 38);
            this.back.TabIndex = 24;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Resident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 593);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_room);
            this.Controls.Add(this.txt_hall);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Phoneno);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Resident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resident";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Phoneno;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_room;
        private System.Windows.Forms.TextBox txt_hall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txt_dob;
        private System.Windows.Forms.ComboBox txt_gender;
        private System.Windows.Forms.Button back;
    }
}

