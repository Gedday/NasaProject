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
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
        public partial class Form1 : Form
        {
            private string conn;
            private MySqlConnection connect;
            public Form1()
            {
                InitializeComponent();
            }

            private void db_connection()
            {
                try
                {
                    conn = "Server=localhost;Database=sys17;Uid=root;Pwd=;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                }
                catch (MySqlException e)
                {            
                    throw e;
                }
            }

            private bool validate_login(string user, string pass)
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from members where username=@username and password=@password";
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Connection = connect;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    connect.Close();
                    return true;
                }
                else
                {
                    connect.Close();
                    return false;
                }
            }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (slide2.Left == 609)
            {
                slide1.Visible = false;
                slide1.Left = 609;

                slide2.Visible = false;
                slide2.Left = 23;
                slide2.Visible = true;
                slide2.Refresh();
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (slide1.Left == 609)
            {
                slide2.Visible = false;
                slide2.Left = 609;

                slide1.Visible = false;
                slide1.Left = 23;
                slide1.Visible = true;
                slide1.Refresh();

            }

        }
    }
}