namespace TowersOfHanoi
{
    public class TowerOfHanoi
    {
        private int numDisks;

        public int NumDisks
        {
            get
            {
                return this.numDisks;
            }

            set
            {
                if (value > 0)
                {
                    this.numDisks = value;
                }
            }
        }

        public void MoveDisks(int totalDisks, int from, int to, int other)
        {
            if (totalDisks > 0)
            {
                this.MoveDisks(totalDisks - 1, from, other, to);
                Console.WriteLine($"Move disk {totalDisks} from tower {from} to tower {to}");
                this.MoveDisks(totalDisks - 1, other, to, from);
            }
        }
    }
}
