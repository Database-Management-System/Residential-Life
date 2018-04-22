using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class Package : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Package()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentId from dbo.Resident", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                txt_id.Items.Add(DR[0]);
            }
            txt_pin.Value = DateTime.Now;
            txt_pout.Value = DateTime.Now;
            con.Close();
            DisplayData();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_pin.Text != "" &&
                txt_pout.Text != "" &&
                txt_perishable.Text != "" &&
                txt_id.Text != "")
            {
                cmd = new SqlCommand("insert into dbo.Package(StudentId,Perishable,Date_In,Date_Out) values (@id,@perishable,@pin,@pout)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@perishable", txt_perishable.Text);
                cmd.Parameters.AddWithValue("@pin", Convert.ToDateTime(txt_pin.Text));
                cmd.Parameters.AddWithValue("@pout", Convert.ToDateTime(txt_pout.Text));
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
            adapt = new SqlDataAdapter("select * from dbo.Package", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_id.Text = "";
            txt_perishable.Text = "";
            txt_pin.Text = "";
            txt_pout.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_perishable.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_pin.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_pout.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_pin.Text != "" &&
           txt_pout.Text != "" &&
           txt_perishable.Text != "" &&
           txt_id.Text != "")
            {
                cmd = new SqlCommand("update dbo.Package set StudentId=@id,Perishable=@perishable," +
                    "Date_In=@pin,Date_Out=@pout where PackageId=@pid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@pid", ID);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@perishable", txt_perishable.Text);
                cmd.Parameters.AddWithValue("@pin", Convert.ToDateTime(txt_pin.Text));
                cmd.Parameters.AddWithValue("@pout", Convert.ToDateTime(txt_pout.Text));
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
                cmd = new SqlCommand("delete dbo.Package where PackageId=@id", con);
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
