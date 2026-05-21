namespace Fun_with_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize;

            Console.WriteLine("You can create a grid. What size should it have?");
            string input  = Console.ReadLine();
            gridSize = Convert.ToInt32(input);
            string[,] grid = new string[gridSize, gridSize];
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = "0";
                }
            }
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write($"{grid[i, j]}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
