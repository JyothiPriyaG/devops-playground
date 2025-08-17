// See https://aka.ms/new-console-template for more information
using MySqlConnector;
using System.Collections.Concurrent;

var name = Environment.GetEnvironmentVariable("NAME") ?? "World";

Console.WriteLine($"Hello, {name}!");

using (var connection = new MySqlConnection($"Server={Environment.GetEnvironmentVariable("DB_HOST")??"localhost"};Port=3306;Database=testdb;Uid=root;Pwd=mysql;"))
{
    connection.Open();
    Console.WriteLine("Connection Opened");
    connection.ChangeDatabase("testdb");
    Console.WriteLine("Changed database to testdb");
    //query persons table
    string query = "SELECT Name FROM persons"; // Assuming 'Name' is the column containing the person's name
    List<string> personNames = new List<string>();
    using (MySqlCommand command = new MySqlCommand(query, connection))
    {
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                personNames.Add(reader.GetString("Name")); // Or reader.GetString(0) if 'Name' is the first column
            }
        }
        foreach (var person in personNames)
        {
            Console.WriteLine($"Hello {person}");
        }
        connection.Close();
    }
}