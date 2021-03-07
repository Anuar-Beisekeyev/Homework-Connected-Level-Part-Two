using HomeworkConnectedLevelPartTwo.Data;
using System;

namespace HomeworkConnectedLevelPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupDataAccess = new GroupDataAccess();
            groupDataAccess.CreateTable();
            groupDataAccess.Dispose();
        }
    }
}
