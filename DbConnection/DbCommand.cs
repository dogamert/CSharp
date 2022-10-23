using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    internal class DbCommand
    {
        private readonly DbConnection _dBConnection;
        private readonly string _data;
        public DbCommand(DbConnection dbConnection, string data)
        {
            if (dbConnection == null)
                throw new ArgumentNullException(nameof(dbConnection) + ": Passed DbConnection object to DBCommand constructor cannot be null.");
            else
                _dBConnection = dbConnection;

            if (String.IsNullOrWhiteSpace(data))
                throw new ArgumentException(nameof(data) + ": Passed string to DBCommand constructor cannot be null, empty, or consists of only white-spaces.");
            else
                _data = data;
        }

        public void Execute()
        {
            _dBConnection.OpenConnection(_dBConnection.ConnectionString, _dBConnection.Timeout);
            Console.WriteLine("Data(instruction): " + _data);
            _dBConnection.CloseConnection();
        }
    }
}
