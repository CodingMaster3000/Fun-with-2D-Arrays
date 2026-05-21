namespace Fun_with_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize;
            int alternatingFactor;
            Console.WriteLine("You can create a grid. What size should it have?");
            string gridSizeInput = Console.ReadLine();
            gridSize = Convert.ToInt32(gridSizeInput);
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
                Console.Write("+");
                for (int j = 0; j < gridSize; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("+");
                   
                }
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write(" ");
                    Console.Write($"{grid[i, j]}");
                    Console.Write(" ");
                    Console.Write("|");

                }
                Console.WriteLine();
            }
            Console.Write("+");
            for (int j = 0; j < gridSize; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("-");
                }
                Console.Write("+");

            }
            Console.WriteLine();
            Console.WriteLine("Should the cells of the grid have alternating values? (y/n)");
            string modealternatingInput = Console.ReadLine().ToLower();
            if (modealternatingInput == "y")
            {
                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        alternatingFactor = Convert.ToInt32(Math.Pow(-1, i + 1) * Math.Pow(-1, j));
                        if (alternatingFactor == 1)
                        {
                            grid[i, j] = "X";
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < gridSize; i++)
                {
                    Console.Write("+");
                    for (int j = 0; j < gridSize; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("+");

                    }
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < gridSize; j++)
                    {
                        Console.Write(" ");
                        Console.Write($"{grid[i, j]}");
                        Console.Write(" ");
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
                Console.Write("+");
                for (int j = 0; j < gridSize; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("+");

                }
            }
        }
    }
}
