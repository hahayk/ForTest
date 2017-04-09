using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using static System.Console;


//public MeContext() : base(@"Data Source=compik;Initial Catalog=MyTestDb;Integrated Security=True") { }


namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Very Simple Connection Factory *****\n");
            string dataProviderString = ConfigurationManager.AppSettings["provider"];
            DataProvider dataProvider = DataProvider.None;
            if (Enum.IsDefined(typeof(DataProvider), dataProviderString))
            {
                dataProvider=(DataProvider)Enum.Parse(typeof(DataProvider), dataProviderString);
            }
            else
            {
                WriteLine("Sorry, no provider exists!");
                ReadLine();
                return;
            }
            IDbConnection myConnection = GetConnection(dataProvider);
            WriteLine($"Your connection is {myConnection?.GetType().Name ?? "unrecognized type"}");

            //Console.WriteLine($"Your connection is {myConnection.GetType().Name}");
            Console.ReadLine();
        }   

        enum DataProvider
        {
            SqlServer, OleDb, Odbc, None
        }

        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
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
