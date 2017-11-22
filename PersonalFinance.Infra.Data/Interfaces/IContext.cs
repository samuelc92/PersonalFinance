using System;
using MySql.Data.MySqlClient;

namespace PersonalFinance.Infra.Data.Interfaces
{
    public interface IContext : IDisposable
    {
        MySqlConnection Connection{ get; }
        MySqlTransaction StartTransaction();
        void Commit();
    }
}