using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectsV13; Initial Catalog =Banking DB; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *  FROM [Banking DB].[dbo].[Login] WHERE User_Name = '"+ textBox1.Text+ 
                "' AND Password = '" + textBox2.Text+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("          Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                Hide();
                Bank_Main main = new Bank_Main();
                main.Show();
            }
            else MessageBox.Show("Invalid Username and Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) => Close();
    }
}
