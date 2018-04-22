using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class Equipment : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapt;
        int ID = 0;
        public Equipment()
        {
            InitializeComponent();
            con.Open();
            cmd = new SqlCommand("select StudentId from dbo.Resident", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                txt_id.Items.Add(DR[0]);
            }
            DR.Close();
            cmd2 = new SqlCommand("select ItemName from dbo.Stock", con);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                txt_iname.Items.Add(DR2[0]);
            }
            DR2.Close();
            txt_ein.Value = DateTime.Now;
            txt_eout.Value = DateTime.Now;
            con.Close();
            DisplayData();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_ein.Text != "" &&
                txt_eout.Text != "" &&
                txt_damaged.Text != "" &&
                txt_id.Text != "" &&
                txt_avail.Text != "" &&
                txt_iname.Text != "")
            {
                cmd = new SqlCommand("insert into dbo.Equipment(StudentId,ItemName,Damaged,Date_In,Date_Out) values (@id,@iname,@damaged,@din,@dout)", con);
                cmd2 = new SqlCommand("update dbo.Stock set ItemCount= ItemCount-1 where ItemName=@iname", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.Parameters.AddWithValue("@damaged", txt_damaged.Text);
                cmd.Parameters.AddWithValue("@din", Convert.ToDateTime(txt_ein.Text));
                cmd.Parameters.AddWithValue("@dout", Convert.ToDateTime(txt_eout.Text));
                cmd2.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
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
            adapt = new SqlDataAdapter("select e.* from dbo.Equipment as e inner join dbo.Stock as s on e.ItemName=s.ItemName", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_id.Text = "";
            txt_damaged.Text = "";
            txt_iname.Text = "";
            txt_avail.Text = "";
            txt_ein.Text = "";
            txt_eout.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_iname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_eout.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ein.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_damaged.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txt_avail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ein.Text != "" &&
           txt_eout.Text != "" &&
           txt_damaged.Text != "" &&
           txt_id.Text != ""&&
           txt_avail.Text !=""&&
           txt_iname.Text !="")
            {
                cmd = new SqlCommand("update dbo.Equipment set StudentId=@id,Damaged=@damaged,ItemName=@iname," +
                    "Date_In=@ein,Date_Out=@eout where EquipmentId=@eid", con);
                cmd2 = new SqlCommand("update dbo.Stock set ItemCount= ItemCount+1 where ItemName=@iname", con);
                con.Open();
                cmd.Parameters.AddWithValue("@eid", ID);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@damaged", txt_damaged.Text);
                cmd.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.Parameters.AddWithValue("@ein", Convert.ToDateTime(txt_ein.Text));
                cmd.Parameters.AddWithValue("@eout", Convert.ToDateTime(txt_eout.Text));
                cmd2.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
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
                cmd = new SqlCommand("delete dbo.Equipment where EquipmentId=@id", con);
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

        private void txt_iname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string chosen = (string)comboBox.SelectedItem;
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select ItemCount from dbo.Stock where ItemName=@chosen", con);
            cmd3.Parameters.AddWithValue("@chosen", chosen);
            Int32 itemcount = (Int32)cmd3.ExecuteScalar();
            txt_avail.Text = itemcount.ToString();
            con.Close();
        }
    }
}
