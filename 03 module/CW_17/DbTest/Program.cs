using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace DbTest
{
    class Program
    {
        private static DataTable ExecuteSQL_DataTable(string connectionString, string SQL,
            params Tuple<string, string>[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                using (SqliteCommand cmd = new SqliteCommand(SQL, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (var tuple in parameters)
                        cmd.Parameters.Add(new SqliteParameter(tuple.Item1, tuple.Item2));
                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                        dt.Columns.Add(new DataColumn(reader.GetName(i)));

                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        dt.Rows.Add(row);
                        for (int i = 0; i < reader.FieldCount; i++)
                            dt.Rows[rowIndex][i] = (reader.GetValue(i));
                        rowIndex++;
                    }
                }
            }

            return dt;
        }

        static void Main(string[] args)
        {
            string connectionString = "Data Source=AdventureWorksLT.db";
            string SQL = "SELECT * FROM Product";
            string SQL2 = "SELECT * FROM Product WHERE ProductID = 680";
            string SQL3 = "SELECT * FROM Product WHERE ListPrice > 680 and ListPrice < 1000";
            string SQL4 = "SELECT * FROM Product WHERE ProductID = 1";

            SqliteConnection con = new SqliteConnection(connectionString);
            con.Open();
            SqliteCommand command = new SqliteCommand();
            command.Connection = con;
            command.CommandText = "UPDATE Product SET StandardCost='100' WHERE ProductID='680'";
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE Product SET ListPrice='100' WHERE ProductID='680'";
            command.ExecuteNonQuery();
            command.CommandText =
                "INSERT INTO Product (ProductID, Name, ProductNumber, StandardCost, ListPrice,  SellStartDate, rowguid) VALUES (10000000, 'NewProduct1', 'A1', 0, 0, '2022-06-01 00:00:00', '011')";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM Product WHERE ProductID='10000000'";
            command.ExecuteNonQuery();
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL4);

            foreach (DataRow row in dt.Rows)
            {
                foreach (var t in row.ItemArray)
                    Console.Write(t + " ");
                Console.WriteLine();
            }
        }
    }
}