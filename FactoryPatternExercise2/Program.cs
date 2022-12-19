namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a database to use.");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Type \"list\" for a list data access.");
            Console.WriteLine("Type \"sql\" for a sql data access.");
            Console.WriteLine("Type \"mongo\" for a mongo data access.");
            Console.WriteLine();

            string userInput = Console.ReadLine();  

            IDataAccess databaseObject = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine();
            databaseObject.LoadData();
            databaseObject.SaveData();
        }
    }
}
