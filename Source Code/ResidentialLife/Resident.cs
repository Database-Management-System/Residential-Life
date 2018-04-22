using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class Resident : Form
    {
        SqlConnection con= new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Resident()
        {
            InitializeComponent();
            DisplayData();
        }
        //Insert Data
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && 
                txt_balance.Text != "" &&
                txt_gender.Text != "" &&
                txt_hall.Text != "" &&
                txt_room.Text != "" &&
                txt_balance.Text != "" &&
                txt_email.Text != "" &&
                txt_dob.Text != "")
            {
                cmd = new SqlCommand("insert into dbo.Resident(StudentID,ResidentName,Gender,PhoneNo,EmailId,Hall,RoomNo,DateOfBirth,Balance) " +
                "values(@id,@name,@gender,@phone,@email,@hall,@room,@dob,@balance)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@phone", txt_Phoneno.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@hall", txt_hall.Text);
            cmd.Parameters.AddWithValue("@room", txt_room.Text);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(txt_dob.Text));
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
            cmd.Parameters.AddWithValue("@balance", txt_balance.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            ClearData();
        }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
}
        //Display Data in DataGridView
        private void DisplayData()
        {
            con.Open();
            DataTable dt=new DataTable();
            adapt=new SqlDataAdapter("select * from dbo.Resident",con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Phoneno.Text = "";
            txt_id.Text = "";
            txt_gender.Text = "";
            txt_hall.Text = "";
            txt_room.Text = "";
            txt_balance.Text = "";
            txt_email.Text = "";
            txt_dob.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_gender.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Phoneno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_hall.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_room.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_dob.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_balance.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" &&
               txt_balance.Text != "" &&
               txt_gender.Text != "" &&
               txt_hall.Text != "" &&
               txt_room.Text != "" &&
               txt_balance.Text != "" &&
               txt_email.Text != "" &&
               txt_dob.Text != "")
            {
                cmd = new SqlCommand("update dbo.Resident set StudentId=@id,ResidentName=@name,Gender=@gender,PhoneNo=@phone," +
                "EmailId=@email,Hall=@hall,RoomNo=@room,DateOfBirth=@dob,Balance=@balance where StudentID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@phone", txt_Phoneno.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@hall", txt_hall.Text);
            cmd.Parameters.AddWithValue("@room", txt_room.Text);
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(txt_dob.Text));
            cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
            cmd.Parameters.AddWithValue("@balance", txt_balance.Text); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            DisplayData();
            ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete Record
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete dbo.Resident where StudentId=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
            ClearData();
        }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
}

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
