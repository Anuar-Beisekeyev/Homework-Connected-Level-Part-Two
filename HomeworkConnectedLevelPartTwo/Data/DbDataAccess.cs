using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HomeworkConnectedLevelPartTwo.Data
{
    public abstract class DbDataAccess<T> : IDisposable
    {
        protected readonly SqlConnection connection;
        public DbDataAccess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-3S2N5VP; Database=ConnectionLevelLesson; Trusted_Connection=True;";
            connection.Open();
        }
        public void Dispose()
        {
            connection.Close();
        }
        public abstract void CreateTable();
    }
}
