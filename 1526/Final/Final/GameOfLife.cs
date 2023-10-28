namespace Final;

public class GameOfLife
{
    private int[,] _generation = new int[10, 10];
    private readonly int[,] _nextGeneration = new int[10, 10];
    private const int RowLength = 10;
    private const int ColumnLength = 10;
    private const int NumberOfGenerations = 10;

    /// <summary>
    /// Starts the game of life.
    /// </summary>
    public void BeginLife()
    {
        PopulateGenerationZero();

        var genCounter = 0;
        while (genCounter < NumberOfGenerations)
        {
            DisplayGeneration(genCounter);
            CreateNextGeneration();
            genCounter++;

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Creates the next generation.
    /// </summary>
    private void CreateNextGeneration()
    {
        for (var i = 0; i < RowLength; i++)
        {
            for (var j = 0; j < ColumnLength; j++)
            {
                CellAnalysis(i, j);
            }
        }

        _generation = _nextGeneration;
    }

    /// <summary>
    /// Updates the status of the current cell based on the number of alive neighbors.
    /// </summary>
    /// <param name="x">The x coordinate of the current cell.</param>
    /// <param name="y">The y coordinate of the current cell.</param>
    private void CellAnalysis(int x, int y)
    {
        var neighbors = GetNeighbors(x, y);
        var aliveNeighbors = neighbors.Count(n => n == 1);
        var currentCell = _generation[x, y];

        if (currentCell == 1)
        {
            if (aliveNeighbors is 2 or 3) _nextGeneration[x, y] = 1;
            else _nextGeneration[x, y] = 0;
        }
        else
        {
            if (aliveNeighbors == 3) _nextGeneration[x, y] = 1;
            else _nextGeneration[x, y] = 0;
        }
    }
    
    /// <summary>
    /// Gets the neighbors of the current cell.
    /// </summary>
    /// <param name="x">The x coordinate of the cell.</param>
    /// <param name="y">The y coordinate of the cell.</param>
    private IEnumerable<int> GetNeighbors(int x, int y)
    {
        var neighbors = new List<int>();

        for (var i = x - 1; i <= x + 1; i++)
        {
            for (var j = y - 1; j <= y + 1; j++)
            {
                if (i == x && j == y) continue;
                if (i is < 0 or >= RowLength) continue;
                if (j is < 0 or >= ColumnLength) continue;
                neighbors.Add(_generation[i, j]);
            }
        }

        return neighbors.ToArray();
    }

    /// <summary>
    /// Displays the current generation.
    /// </summary>
    /// <param name="genCounter">The generation counter.</param>
    private void DisplayGeneration(int genCounter)
    {
        Console.WriteLine($"Generation {genCounter}");
        for (var i = 0; i < RowLength; i++)
        {
            for (var j = 0; j < ColumnLength; j++)
            {
                Console.Write(_generation[i, j] == 1 ? "*" : " " );
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    /// <summary>
    /// Populates the first generation with random values.
    /// </summary>
    private void PopulateGenerationZero()
    {
        var random = new Random();
        for (var i = 0; i < RowLength; i++)
        {
            for (var j = 0; j < ColumnLength; j++)
            {
                _generation[i, j] = random.Next(0, 2);
            }
        }
    }
}