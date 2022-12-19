using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Mongo Database.. ");
            Console.WriteLine("You probably should have chosen a List.. ");
        }

        public void SaveData()
        {
            Console.WriteLine();
            Console.WriteLine("Saving Mongo Database.. ");
            Console.WriteLine("Still saving Mongo Database..");
        }
    }
}