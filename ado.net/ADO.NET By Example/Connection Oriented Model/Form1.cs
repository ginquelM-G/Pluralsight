using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_Oriented_Model
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string cmpName;
        decimal revenue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string cs = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = ADO_by_example; Data Source = GINQUELM-E";
            con = new SqlConnection(cs);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmpName = txtCmpName.Text;
            revenue = decimal.Parse(txtRevenue.Text);
            cmd.Parameters.Clear();
            cmd.CommandText = "Insert Into CompanyRevenue values(@cmpName, @revenue)";
            cmd.Parameters.AddWithValue("@cmpName", cmpName);
            cmd.Parameters.AddWithValue("@revenue", revenue);

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Command Added Successfully...","Sucess");
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            string cmpName = txtCmpName.Text;
           
            cmd.Parameters.Clear();
            cmd.CommandText = "select revenue From CompanyRevenue where companyName = @cmpName";
            cmd.Parameters.AddWithValue("@cmpName", cmpName);
           
            if (con.State == ConnectionState.Closed)
                con.Open();

            revenue = (decimal)cmd.ExecuteScalar();
            txtRevenue.Text = revenue.ToString();

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCmpName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_preview_Click(object sender, EventArgs e)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Select * from CompanyRevenue";
            
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            // Histograma(grafo)
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "CompanyName";
            chart1.Series[0].YValueMembers = "Revenue";
            chart1.DataBind();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            cmpName = txtCmpName.Text;
            revenue = decimal.Parse(txtRevenue.Text);
            
            cmd.Parameters.Clear();
            cmd.CommandText = "update  CompanyRevenue set revenue=@revenue where companyName = @cmpName";
            cmd.Parameters.AddWithValue("@cmpName", cmpName);
            cmd.Parameters.AddWithValue("@revenue", revenue);

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();
            txtCmpName.Clear();
            txtRevenue.Clear();

            con.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            cmpName = txtCmpName.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "delete CompanyRevenue where companyName = @cmpName";
            cmd.Parameters.AddWithValue("@cmpName", cmpName);
        
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();
            txtCmpName.Clear();

            con.Close();
        }
    }
}
