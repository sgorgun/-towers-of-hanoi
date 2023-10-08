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
                this.MoveDisks(totalDisks - 1, sourceTower, tempTower, targetTower);
                Console.WriteLine($"Move disk {totalDisks} from tower {sourceTower} to tower {targetTower}");
                this.MoveDisks(totalDisks - 1, tempTower, targetTower, sourceTower);
            }
        }
    }
}
