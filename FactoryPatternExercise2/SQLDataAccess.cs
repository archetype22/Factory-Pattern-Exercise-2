using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading SQL Database.. ");
            Console.WriteLine("Ahhhh, the SQL Database..");
        }

        public void SaveData()
        {
            Console.WriteLine();
            Console.WriteLine("Saving SQL Database.. ");
            Console.WriteLine("The valet is outside with your car, citizen. ");
        }
    }
}
