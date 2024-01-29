using DatabaseConnectionNetF.conn;
using System.Data.Common;

namespace DatabaseConnectionNetF.core
{
    public delegate void Config(ConnectionFactory factory);
    public interface IConnection
    {
        DbConnection GenerateConnection(Config config);
    }
}
