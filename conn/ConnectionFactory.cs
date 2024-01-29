
using DatabaseConnectionNetF.core;
using System;

namespace DatabaseConnectionNetF.conn
{
    public class ConnectionFactory
    {
        public string DbName { get; private set; }

        public string host { get; private set; }

        public int Port { get; private set; }

        private bool noPort = true;

        public string user { get; private set; }

        public string password { get; private set; }

        public DbTypes DbType { get; private set; }

        public ConnectionFactory Dbname(string dbname)
        {
            this.DbName = dbname;
            return this;
        }

        public ConnectionFactory Host(string host)
        {
            this.host = host;
            return this;
        }

        public ConnectionFactory port(int port)
        {
            this.Port = port;
            noPort = false;
            return this;
        }

        public ConnectionFactory User(string user)
        {
            this.user = user;
            return this;
        }

        public ConnectionFactory Password(string password)
        {
            this.password = password;
            return this;
        }

        public ConnectionFactory TypeDb(DbTypes dbType)
        {
            this.DbType = dbType;
            return this;
        }


        public string StringConnection()
        {
            return getSqlString();
        }

        private string getSqlString()
        {
            if (noPort)
            {
                switch (this.DbType)
                {
                    case DbTypes.PostgreSql:
                        return $"Host={host};Username={user};Password={password};Database={DbName};";
                    case DbTypes.SqlServer:
                        return $"Data Source={host};Initial Catalog={DbName};User ID={user};Password={password};";
                    case DbTypes.SqlServerMicrosoft:
                        return $"Data Source={host};Initial Catalog={DbName};User ID={user};Password={password};";
                    case DbTypes.Mysql:
                        return $"Server={host};Database={DbName};User Id={user};Password={password};";
                    default:
                        Logger.errorLog($"Tipo de banco [{DbType}] de dados não suportado", true, this);
                        throw new Exception($"Tipo de banco [{DbType}] de dados não suportado");
                }
            }
            else
            {
                switch (this.DbType)
                {
                    case DbTypes.PostgreSql:
                        int? porta = Port == 0 ? 5432 : Port;
                        return $"Host={host};Port={porta};Username={user};Password={password};Database={DbName};";
                    case DbTypes.SqlServer:
                        int? portaSqlServer = Port == 0 ? 1433 : Port;
                        return $"Data Source={host},{portaSqlServer};Initial Catalog={DbName};User ID={user};Password={password};";
                    case DbTypes.SqlServerMicrosoft:
                        int? portaSqlServerMicrosoft = Port == 0 ? 1433 : Port;
                        return $"Data Source={host},{portaSqlServerMicrosoft};Initial Catalog={DbName};User ID={user};Password={password};";
                    case DbTypes.Mysql:
                        int? portaMysql = Port == 0 ? 3306 : Port;
                        return $"Server={host};Port={portaMysql};Database={DbName};User Id={user};Password={password};";
                    default:
                        Logger.errorLog($"Tipo de banco [{DbType}] de dados não suportado", true, this);
                        throw new Exception($"Tipo de banco [{DbType}] de dados não suportado");
                }
            }
        }
    }
}
