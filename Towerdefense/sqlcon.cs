using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Towerdefense
{ 
class sqlcon : login
{
    #region var
    public static SqlConnection con = new SqlConnection();
    public static SqlCommand cmd = new SqlCommand();
    public static string Connection = @"Server=(localdb)\MSSQLLocalDB; Database=Towerdefense; Integrated Security = true";
    public static string Username = login.username1;
    #endregion

    public static void OpenConnection() //opens the sql connection
    {

        con = new SqlConnection(Connection);
        con.Open();
    }
    public static void CloseConnection() //close the sql connection
    {
        con.Close();
    }

    public static void ExecuteQueries(string Query, SqlConnection con) // do an cmdcommand
    {
        SqlCommand cmd = new SqlCommand(Query, con);
        cmd.ExecuteNonQuery();
    }

    public static SqlDataReader DataReader(string Query)//read something
    {
        SqlCommand cmd = new SqlCommand(Query, con);
        SqlDataReader dataread = cmd.ExecuteReader();
        return dataread;

    }

    public static int Updatehighscore(string Username, int highscore)//update highscore for the username witch is logged in
    {
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "Update register SET highscore = '" + highscore + "' where Username = '" + Username + "'";
        highscore = Convert.ToInt32(cmd.ExecuteNonQuery());
        con.Close();
        return highscore;
    }

    public static string gethighscore()//get the highscore of the user witch is logged in 
    {
        string highscore = String.Empty;

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "Select Highscore from register where Username ='" + username1 + "'";
        highscore = Convert.ToString(cmd.ExecuteScalar());
        con.Close();
        return highscore;
    }

    public static string getusername()//get the username of the user witch is logged in
    {
        string username;

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = "Select * from register where Username = '" + username1 + "'";
        username = Convert.ToString(cmd.ExecuteScalar());
        con.Close();
        return username;
    }

    public static void selecttowerplace(int number) 
    {
        towerselect.temp = number;
        
    }

    public static int towerselectint() 
    {
        int number = 0;
        towerselect.temp = number;
        return number;
    }
    
    public static void changetower(int number) 
    {
        towerselect.changeTowerNumber = number;
        
    }

}
}

