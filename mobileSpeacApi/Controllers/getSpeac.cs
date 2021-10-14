using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class getSpeac
{
    private string connetionString;
    private SqlConnection cnn;

    public getSpeac()
    {
        connetionString = @"server=LAPTOP-7A012LKL\SQLEXPRESS; database =SPECIFICATIONS ; integrated security =true";
        cnn = new SqlConnection(connetionString);
    }
    public string  CheckConnection()
    {
        cnn.Open();
        Console.WriteLine("Connection Open  !");
        cnn.Close();
        return "Connection Open  !";
    }

    public string GetSpecById(int id)
    {
        cnn.Open();
        string query = "SELECT * FROM Samsung where id =" + id + ";";
        SqlCommand command = new SqlCommand(query, cnn);
        //SqlDataReader reader = command.ExecuteReader();
        //var speac = reader.Read();
        SqlDataReader dr = command.ExecuteReader();
        string speac;
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                speac = dr["Name"].ToString();
                return speac;
                cnn.Close();
            }
            return "";
        }
        else
        {
            return "";
        }
    }

    public List<string> GetSpecByName(string name)
    {
        cnn.Open();
        string query = String.Format("select * from Samsung where Name LIKE '%{0}%' ;", name);
        SqlCommand command = new SqlCommand(query, cnn);

        SqlDataReader dr = command.ExecuteReader();
        List<string> speac=new List<string>();
        if (dr.HasRows)
        {
            while (dr.Read())
            {

                for (int i = 0; i < 41; i++)
                {
                    speac.Add(dr[i].ToString());
                }
                return speac;
                cnn.Close();
            }
            return speac;
        }
        else
        {
            return speac;
        }
    }
}
