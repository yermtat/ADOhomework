using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appSettings.json");
var config = builder.Build();

var connString = config.GetConnectionString("Default");
using SqlConnection conn = new SqlConnection(connString);
conn.Open();

SqlCommand command;

/*command = new("select avg(salary) from Teachers", conn);
var avg = command.ExecuteScalar();
Console.WriteLine($"Average salary: {avg}");

command = new("select min(salary) from Teachers", conn);
var min = command.ExecuteScalar();
Console.WriteLine($"Minimal salary: {min}");

command = new("select count(*) from teachers where salary < 1000", conn);
var count = command.ExecuteScalar();
Console.WriteLine($"Salary less than 1000: {count}");*/




//command = new("insert into Subjects(Name) values('History of art')", conn);
//command.ExecuteNonQuery();

//command = new("select * from Subjects", conn);
//{

//    using SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}\t{reader[1]}");

//    }
//    Console.WriteLine();
//}


//command = new("update Teachers set Name=N'Rick', Surname=N'Astley' where Id=5", conn);
//command.ExecuteNonQuery();

//command = new("select * from Teachers", conn);

//{

//    using SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}\t{reader[1]}");

//    }
//    Console.WriteLine();
//}


//command = new("delete from Subjects where Name='History of art'", conn);
//command.ExecuteNonQuery();

//command = new("select * from Subjects", conn);
//{

//    using SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}\t{reader[1]}");

//    }
//    Console.WriteLine();
//}


