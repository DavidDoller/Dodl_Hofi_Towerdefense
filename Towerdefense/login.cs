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

namespace Towerdefense
{
    public partial class login : Form
    {
        public static string username1;
        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Pw = txt_password.Text;
            string username = txt_username.Text;
            username1 = txt_username.Text;
            string connectionstring = @"Server='(localdb)\MSSQLLocalDB';Integrated Security = true;"; //server where database gets created

            SqlConnection temp = new SqlConnection(connectionstring);//sqlcon for the database
            SqlCommand cmdtemp = new SqlCommand("select Count(*) from master.dbo.sysdatabases where name = 'Towerdefense'", temp);//count if there is a database with the name Towerdefense  
            temp.Open();

            if (!((int)cmdtemp.ExecuteScalar() == 1)) //if there is no database, database gets created
            {
                SqlCommand cmd = new SqlCommand("Create Database Towerdefense", temp);//create database
                cmd.ExecuteNonQuery();
                temp.Close();
                sqlcon.OpenConnection();
                sqlcon.ExecuteQueries("CREATE TABLE register (Username varchar(50), Password varchar(50), highscore int)", sqlcon.con);//create table for the database
                sqlcon.CloseConnection();

            }

            temp.Close();
            //control the username and the password
            #region control account 
            sqlcon.OpenConnection();

            if (username != string.Empty && Pw != string.Empty)//check if there is no empty textbox 
            {

                SqlCommand cmd = new SqlCommand("select * from register where username='" + username + "' and password='" + Pw + "'", sqlcon.con); //select the username and the Password from the database register
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)//if datareader has rows and account exists open the menu form
                {
                    menu form = new menu();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Diesen Benutzer gibt es nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Füllen Sie alle Felder ausfüllen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlcon.CloseConnection();
            #endregion
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            register form = new register();
            form.Show();
            this.Hide();
        }
    }
}
