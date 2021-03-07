using HomeworkConnectedLevelPartTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HomeworkConnectedLevelPartTwo.Data
{
    public class GroupDataAccess : DbDataAccess<Group>
    {
        public override void CreateTable()
        {
            var createTableSqlScript = $"Create table Groups (Id int primary key identity, Name Nvarchar(30) not null); ";
            using (var command = new SqlCommand(createTableSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
            
        }
    }
}
