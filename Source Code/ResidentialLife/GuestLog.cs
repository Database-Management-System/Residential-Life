using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class GuestLog : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public GuestLog()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentId from dbo.Resident", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                txt_id.Items.Add(DR[0]);
            }
            txt_gtimein.Value = DateTime.Now ;
            txt_gtimeout.Value = DateTime.Now;
            con.Close();
            DisplayData();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_gtimein.Text != "" &&
                txt_gtimeout.Text != "" &&
                txt_gname.Text != "" &&
                txt_id.Text != "" )
            {
                cmd = new SqlCommand("insert into dbo.GuestLog(StudentId,GuestName,Guest_In,Guest_Out) values (@id,@name,@gin,@gout)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@name", txt_gname.Text);
                cmd.Parameters.AddWithValue("@gin", Convert.ToDateTime(txt_gtimein.Text));
                cmd.Parameters.AddWithValue("@gout", Convert.ToDateTime(txt_gtimeout.Text));
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
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.GuestLog", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_id.Text = "";
            txt_gname.Text = "";
            txt_gtimein.Text = "";
            txt_gtimeout.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_gname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_gtimein.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_gtimeout.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_gtimein.Text != "" &&
           txt_gtimeout.Text != "" &&
           txt_gname.Text != "" &&
           txt_id.Text != "")
            {
                cmd = new SqlCommand("update dbo.GuestLog set StudentId=@sid,GuestName=@name,Guest_In=@gin,Guest_Out=@gout where GuestLogId=@gid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@gid", ID);
                cmd.Parameters.AddWithValue("@sid", txt_id.Text);
                cmd.Parameters.AddWithValue("@name", txt_gname.Text);
                cmd.Parameters.AddWithValue("@gin", Convert.ToDateTime(txt_gtimein.Text));
                cmd.Parameters.AddWithValue("@gout", Convert.ToDateTime(txt_gtimeout.Text));
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
                cmd = new SqlCommand("delete dbo.GuestLog where GuestLogId=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
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
