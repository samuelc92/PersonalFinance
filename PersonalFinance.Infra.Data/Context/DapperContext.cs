using Dapper.FluentMap;
using MySql.Data.MySqlClient;
using PersonalFinance.Infra.Data.EntityMap;
using PersonalFinance.Infra.Data.Interfaces;
using Dapper.FluentMap.Dommel;

namespace PersonalFinance.Infra.Data.Context
{
    public sealed class DapperContext : IContext
    {
        private MySqlTransaction _transaction;
        private MySqlConnection _connection;
        public MySqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = CreateMySqlConnection();
                return _connection;
            }
        }

        public DapperContext()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new BankAccountMap());
                config.ForDommel();
            });
        }

        private MySqlConnection CreateMySqlConnection()
        {
            var conn = new MySqlConnection
            {
                ConnectionString = @"Server=localhost;database=PersonalFinance;uid=root;pwd=admin"
            };
            conn.Open();
            return conn;
        }
        public MySqlTransaction StartTransaction()
            => _transaction ?? (_transaction = Connection.BeginTransaction());

        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();
            if (_connection != null)
                _connection.Dispose();
        }
    }
}