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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            #region var
            string username = txt_username.Text;
            string Pw = txt_pw.Text;
            string confirmpw = txt_confirmpw.Text;
            int highscore = 0;
            string connectionstring = @"Server='(localdb)\MSSQLLocalDB';Integrated Security = true;"; //server of where database shut get create
            #endregion

            #region create database
            SqlConnection temp = new SqlConnection(connectionstring);//sqlcon for the database
            SqlCommand cmdtemp = new SqlCommand("select Count(*) from master.dbo.sysdatabases where name = 'Towerdefense'", temp);//count if there is a database with the name Flappybrid  
            temp.Open();

            if (!((int)cmdtemp.ExecuteScalar() == 1)) //if there is no database, database get created
            {
                SqlCommand cmd = new SqlCommand("Create Database Flappybird", temp);//create database
                cmd.ExecuteNonQuery();
                temp.Close();
                sqlcon.OpenConnection();
                sqlcon.ExecuteQueries("CREATE TABLE register (Username varchar(50), Password varchar(50), highscore int)", sqlcon.con);//create table for the database
                sqlcon.CloseConnection();

            }
            temp.Close();
            #endregion
            //create the account to login with it
            #region create account
            //SqlCommand cd = new SqlCommand("Create database if not exist Login;");
            sqlcon.OpenConnection();


            if (Pw == confirmpw) //check if pw is correct
            {

                if (username != string.Empty && Pw != string.Empty)
                {
                    //SqlCommand cmdd = new SqlCommand("create table if not exists Login (username varchar(50), password varchar(50))", con);
                    SqlCommand cmd = new SqlCommand("insert into register values(@Username,@Password,@Highscore)", sqlcon.con);//Insert the values into the database
                    cmd.Parameters.AddWithValue("username", username);//insert into username
                    cmd.Parameters.AddWithValue("Password", Pw);//insert into password
                    cmd.Parameters.AddWithValue("Highscore", highscore);//insert into highscore
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account erstellt!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.CloseConnection();

                    //open Login forms
                    login form = new login();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sie müssen alles ausfühlen!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Das Passwort stimmbt nicht übereinander!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
    }
}
