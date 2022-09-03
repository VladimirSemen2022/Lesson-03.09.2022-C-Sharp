using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;

namespace Lesson_03._09._2022_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strJSON = File.ReadAllText("sample4.json");
            ////Console.WriteLine(strJSON);
            ////List <Peop> people = new List<Peop>();
            ////people = JsonSerializer.Deserialize<Peop>(strJSON);
            ////people.ForEach(Console.WriteLine());

            //People people = JsonSerializer.Deserialize<People>(File.ReadAllText("sample4.json"));
            //people.Show();

            //Connection to SQL-BD

            try
            {
                string fileSettings = @"D:\DBSetting.json";
                ConnectionToBase newConnection = new ConnectionToBase();
                newConnection.GetSettingsFromFile();

                using (SqlConnection connection = new SqlConnection(newConnection.defaultsetting.ToString()))
                {
                    connection.Open();
                    Console.WriteLine("Connection to SQL-Base successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
