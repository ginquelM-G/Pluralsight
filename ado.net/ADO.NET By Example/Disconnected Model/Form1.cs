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

namespace Disconnected_Model
{
    public partial class Form1 : Form
    {
        //private TextBox txtEmpNo, txtEname, txtSalary;
        //private DateTime dtpHiredate;
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = ADO_by_example; Data Source = GINQUELM-E";
            SqlConnection con = new SqlConnection(cs);
           
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Employees", con);
            SqlCommandBuilder cmdB = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();

           
            da.Fill(ds, "Employees");
            ds.Tables[0].Constraints.Add("EmpNo_PK", ds.Tables[0].Columns[0], true);
            DataRow row;
            row = ds.Tables[0].NewRow();
            row["EmpNo"] = txtEmpNo.Text;
            row["Ename"] = txtEname.Text;
            row["Salary"] = txtSalary.Text;
            row["Hiredate"] = dtpHiredate.Value;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Employee Record Added.", this.Text);
        }
    }
}
