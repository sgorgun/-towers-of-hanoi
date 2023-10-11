namespace TowersOfHanoi
{
    public class TowerOfHanoi
    {
        private int numDisks;

        public int NumDisks
        {
            get => this.numDisks;

            set
            {
                if (value > 0)
                {
                    this.numDisks = value;
                }
            }
        }

        public void MoveDisks(int totalDisks, int sourceTower, int targetTower, int tempTower)
        {
            if (totalDisks > 0)
            {
#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters
                this.MoveDisks(totalDisks - 1, sourceTower, tempTower, targetTower);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
                Console.WriteLine($"Move disk {totalDisks} from tower {sourceTower} to tower {targetTower}");
#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters
                this.MoveDisks(totalDisks - 1, tempTower, targetTower, sourceTower);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
            }
        }
    }
}
