using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResidentialLife
{
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7U3N1M6\\SQLEXPRESS;Initial Catalog=ResidentialLife;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String chosenrecord = "";
        public Stock()
        {
            InitializeComponent();
            DisplayData();
        }
        //Insert Data
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_iname.Text != "" &&
                txt_count.Text != "")
            {
                cmd = new SqlCommand("insert into dbo.Stock(ItemName,ItemCount,Price) " +
                "values(@iname,@icount,@price)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.Parameters.AddWithValue("@icount", txt_count.Text);
                cmd.Parameters.AddWithValue("@price", txt_price.Text);
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
            adapt = new SqlDataAdapter("select * from dbo.Stock", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data 
        private void ClearData()
        {
            txt_iname.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   chosenrecord = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_iname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_count.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_count.Text != "" &&
               txt_iname.Text != "")
            {
                cmd = new SqlCommand("update dbo.Stock set ItemCount=@icount,Price=@price where ItemName=@iname", con);
                con.Open();
                cmd.Parameters.AddWithValue("@iname", txt_iname.Text);
                cmd.Parameters.AddWithValue("@icount", txt_count.Text);
                cmd.Parameters.AddWithValue("@price", txt_price.Text);
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
            if (chosenrecord!=null)
            {
                cmd = new SqlCommand("delete dbo.Stock where ItemName=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_iname.Text);
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
