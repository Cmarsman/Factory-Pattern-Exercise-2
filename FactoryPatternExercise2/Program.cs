using System.Security.Cryptography.X509Certificates;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database do you want to use? [ List, SQL, or Mongo?]");
            string userInput = Console.ReadLine();

            IDataAccess instance = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine($"Thank you for choosing {userInput}");
        }
    }
}
