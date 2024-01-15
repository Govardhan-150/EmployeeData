using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Globalization;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        private string Connection_String = "Data Source=LAPTOP-MBP1NFEK\\SQLEXPRESS;Initial Catalog=Employee_Data;Integrated Security=True;TrustServerCertificate=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Sql_con = new SqlConnection(Connection_String);
            bool isMale = (groupBox1.Text == "Male") ? true : false;
            double BasicSalary = double.Parse(EmpSalary.Text);
            double DearnessAllowance = BasicSalary * 0.4;
            double ConveyanceAllowance = Math.Min(DearnessAllowance * 0.1, 250);
            double HouseRentAllowance = Math.Max(BasicSalary * 0.25, 1500);
            double GrossSalary = BasicSalary + DearnessAllowance + ConveyanceAllowance + HouseRentAllowance;
            double Pt = (GrossSalary <= 3000) ? 100 : ((GrossSalary <= 6000) ? 150 : 200);
            double TotalSalary = BasicSalary + DearnessAllowance + ConveyanceAllowance + HouseRentAllowance - Pt;
            Sql_con.Open();
            if (Sql_con.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Employee] ([EmployeeCode],[EmployeeName],[DateOfBirth],[Gender],[Department],[Designation],
                    [BasicSalary],[DearnessAllowance],[ConveyanceAllowance],[HouseRentAllowance],[TotalSalary])VALUES('" + EmpCode.Text + "','" + EmpName.Text + "','" + DateTime.Text + "','" + isMale + "','" + empDept.SelectedItem.ToString() + "','" + EmpDesig.SelectedItem.ToString() + "','" + EmpSalary.Text + "','" + DearnessAllowance.ToString() + "','" + ConveyanceAllowance.ToString() + "','" + HouseRentAllowance.ToString() + "','" + TotalSalary.ToString() + "')");
                cmd.Connection = Sql_con;
                cmd.ExecuteNonQuery();

                gridbind();
                Sql_con.Close();

                MessageBox.Show("Record Inserted sucessfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isMale = (groupBox1.Text == "Male") ? true : false;
            double BasicSalary = double.Parse(EmpSalary.Text);
            double DearnessAllowance = BasicSalary * 0.4;
            double ConveyanceAllowance = Math.Min(DearnessAllowance * 0.1, 250);
            double HouseRentAllowance = Math.Max(BasicSalary * 0.25, 1500);
            double GrossSalary = BasicSalary + DearnessAllowance + ConveyanceAllowance + HouseRentAllowance;
            double Pt = (GrossSalary <= 3000) ? 100 : ((GrossSalary <= 6000) ? 150 : 200);
            double TotalSalary = BasicSalary + DearnessAllowance + ConveyanceAllowance + HouseRentAllowance - Pt;
            SqlConnection con = new SqlConnection(Connection_String);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Employee]
   SET [EmployeeCode] = '" + EmpCode.Text + "',[EmployeeName] = '" + EmpName.Text + "',[DateOfBirth] = '" + DateTime.Text + "',[Gender] ='" + isMale + "',[Department] = '" + empDept.Text + "',[Designation] = '" + EmpDesig.Text + "',[BasicSalary] = '" + BasicSalary + "',[DearnessAllowance] ='" + DearnessAllowance + "',[ConveyanceAllowance] = '" + ConveyanceAllowance + "',[HouseRentAllowance] = '" + HouseRentAllowance + "',[TotalSalary] = '" + TotalSalary + "' WHERE[EmployeeCode]='" + EmpCode.Text + "'", con);
            cmd.ExecuteNonQuery();
            gridbind();
            con.Close();
            MessageBox.Show("Record updated successfull");
        }

        private void empDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            gender = "Male";
            groupBox1.Text = gender;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            groupBox1.Text = gender;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridbind();
        }
        private void gridbind()
        {
            SqlConnection con = new SqlConnection(Connection_String);
            con.Open();
            SqlCommand cmd = new SqlCommand("GetEmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
