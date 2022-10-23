using DatabaseConnection;
using System.Threading;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Open and Close DB Connection Example for SQL\n");
  
            var sqlDatabase_Connection = new SqlConnection("123");
            sqlDatabase_Connection.OpenConnection("123", new System.TimeSpan(0,0,1));
            System.Console.WriteLine("GetDbConnectionStatus: " + sqlDatabase_Connection.GetDbConnectionStatus());
            sqlDatabase_Connection.CloseConnection();
            System.Console.WriteLine("GetDbConnectionStatus: " + sqlDatabase_Connection.GetDbConnectionStatus());


            System.Console.WriteLine("\nOpen and Close DB Connection Example for Oracle\n");

            var oracleDatabase_Connection = new OracleConnection("123");
            oracleDatabase_Connection.OpenConnection("123", new System.TimeSpan(0, 0, 1));
            System.Console.WriteLine("GetDbConnectionStatus: " + oracleDatabase_Connection.GetDbConnectionStatus());
            oracleDatabase_Connection.CloseConnection();
            System.Console.WriteLine("GetDbConnectionStatus: " + oracleDatabase_Connection.GetDbConnectionStatus());

            System.Console.WriteLine("\nExecute method in DbCommands with SQL DB\n");
            var dbCommand_Execute_SQL = new DbCommand(sqlDatabase_Connection, "Hello");
            dbCommand_Execute_SQL.Execute();

            System.Console.WriteLine("\nExecute method in DbCommands with Oracle DB\n");
            var dbCommand_Execute_Oracle = new DbCommand(oracleDatabase_Connection, "Hello");
            dbCommand_Execute_Oracle.Execute();
        }
    }
}
