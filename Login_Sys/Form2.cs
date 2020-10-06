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

namespace Login_Sys
{
    public partial class Form2 : Form
    {
        public SqlConnection sql = new SqlConnection("Data Source=DESKTOP-FHLIQJS;Initial Catalog=MasterDB;Integrated Security=True");
        public SqlDataReader reader = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbsenha_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
           
            SqlCommand conn = new SqlCommand("select login,Password from login where situacao=1 and login =('@login') and Password =('@Password')", sql);
            conn.Parameters.Add("@login", SqlDbType.Char).Value = Entlogin.Text;
            conn.Parameters.Add("@Password", SqlDbType.Char).Value = entSenha.Text;

    
            try
            {
                sql.Open();
                reader = conn.ExecuteReader();
                while (reader.Read()) ;
          
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
