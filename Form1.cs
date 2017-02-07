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
using System.Runtime.InteropServices;

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
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }


        /// Gör klassen dragbar^ Ändra inte den koden.

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton1_Click(object sender, EventArgs e)
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

        private void RegisterButton1_Click(object sender, EventArgs e)
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

        private void SignInButton2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
    }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void slide1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        }



