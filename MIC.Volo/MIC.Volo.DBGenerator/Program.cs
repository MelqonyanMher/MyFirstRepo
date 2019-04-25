using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace MIC.Volo.DBGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            FillBase();
        }
        static void FillBase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLlocaldb;Initial Catalog=PFM;Integrated Security=True";
            SqlConnection conection = new SqlConnection(connectionString);
            SqlCommand comand = new SqlCommand();
            conection.Open();
            string readId = "Select Id from dbo.Category";
            comand.CommandText = readId;
            comand.Connection = conection;
            SqlDataReader reader = comand.ExecuteReader();
            List<string> categoryId = new List<string>();
            while (reader.Read())
            {
                categoryId.Add(reader[0].ToString());
            }
            reader.Close();
            string instComand;
            Random rd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                instComand = $"insert into Wallet (CategoryId,Amount,Day) values ('{categoryId[rd.Next(categoryId.Count)]}',{rd.Next(-200000, 600000)},getutcdate())";
                comand.CommandText = instComand;
                comand.ExecuteNonQuery();
            }
            comand.Dispose();
            conection.Dispose();
        }
    }
}
