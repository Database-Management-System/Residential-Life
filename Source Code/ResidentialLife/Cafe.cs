using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class Cafe : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlDataAdapter adapt;
        int ID = 0;
        public Cafe()
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
            con.Close();
            DisplayData();
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_iname.Text!=""&&
                txt_id.Text != ""&&
                txt_price.Text!="")
            {
                cmd = new SqlCommand("insert into dbo.Cafe(StudentId,ItemName) values (@id,@iname)", con);
                cmd2 = new SqlCommand("update dbo.Stock set ItemCount= ItemCount-1 where ItemName=@iname", con);
                cmd3 = new SqlCommand("update dbo.Resident set Balance=Balance-@price where StudentId=@id", con);
                con.Open();
                Int32 id = Int32.Parse(txt_id.Text);
                float price = float.Parse(txt_price.Text);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.Parameters.AddWithValue("@price", txt_price.Text);
                cmd2.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd3.Parameters.AddWithValue("@id", id);
                cmd3.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
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
            adapt = new SqlDataAdapter("select c.* from dbo.Cafe as c inner join dbo.Stock as s on c.ItemName=s.ItemName" +
                " inner join dbo.resident as r on c.StudentId=r.StudentId", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_id.Text = "";
            txt_iname.Text = "";
            txt_avail.Text = "";
            txt_price.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        //Delete Record
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete dbo.Cafe where ItemId=@id", con);
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
            SqlCommand cmd4 = new SqlCommand("select Price from dbo.Stock where ItemName=@chosen", con);
            cmd4.Parameters.AddWithValue("@chosen", chosen);
            //decimal price = (decimal)cmd4.ExecuteScalar();
            decimal price = Convert.ToDecimal(cmd4.ExecuteScalar());
            txt_price.Text = price.ToString();
            con.Close();
        }
    }
}
