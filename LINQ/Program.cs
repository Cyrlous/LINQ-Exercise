namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gamesList = new List<string>() {"Super Mario Bros.", "Quake", "Sonic the Hedgehog", "Final Fantasy", "Dragon Quest"};
            
            var sortedGamesList = gamesList.OrderBy(x => x.Length).ToList();
            
            Console.WriteLine("List of great games:");
            Console.WriteLine("-----------");
            sortedGamesList.ForEach(Console.WriteLine);
        }
    }
}
