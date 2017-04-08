using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

//public MeContext() : base(@"Data Source=compik;Initial Catalog=MyTestDb;Integrated Security=True") { }


namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Very Simple Connection Factory *****\n");
            IDbConnection myConnection = GetConnection(DataProvider.Sql);
            Console.WriteLine($"Your connection is {myConnection.GetType().Name}");
            Console.ReadLine();
        }

        enum DataProvider
        {
            Sql, OleDb, Odbc, None
        }

        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.Sql:
                    connection = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection();
                    break;
                default:
                    break;
            }

            return connection;
        }

    }
    
}
