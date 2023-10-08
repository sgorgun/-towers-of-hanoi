namespace TowersOfHanoi
{
    public static class TowersOfHanoiApp
    {
        public static void Main()
        {
            var tower = new TowerOfHanoi();
            int numdiscs;

            while (true)
            {
                Console.Write("Enter the number of discs: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out numdiscs) && numdiscs > 0)
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            tower.NumDisks = numdiscs;
            tower.MoveDisks(tower.NumDisks, 1, 3, 2);
            Console.ReadLine();
        }
    }
}
