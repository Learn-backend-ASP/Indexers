public class Sudoku
{
    private int[,] _matrix;
    private const int Size = 9; // Sudoku board size (9x9)

    public Sudoku(int[,] matrix)
    {
        // Validate board dimensions
        if (matrix.GetLength(0) != Size || matrix.GetLength(1) != Size)
            throw new ArgumentException($"Invalid Sudoku board size. Must be {Size}x{Size}.");

        _matrix = matrix;
    }

    public int this[int row, int col]
    {
        get
        {
            if (!IsValidIndex(row, col))
                return -1;
            return _matrix[row, col];
        }
        set
        {
            if (!IsValidPosition(row, col, value))
                return;
            _matrix[row, col] = value;
            Console.WriteLine($"✅ Value {value} successfully placed at [{row},{col}].");
        }
    }

    // ✅ Validation helpers
    private bool IsValidIndex(int row, int col)
    {
        bool valid = row >= 0 && row < Size && col >= 0 && col < Size;
        if (!valid)
            Console.WriteLine($"⚠️ Invalid position [{row},{col}]. Must be within 0–{Size - 1}.");
        return valid;
    }

    private bool IsValidPosition(int row, int col, int value)
    {
        if (!IsValidIndex(row, col))
            return false;
        if (value < 1 || value > 9)
        {
            Console.WriteLine($"⚠️ Invalid value ({value}). Sudoku numbers must be between 1 and 9.");
            return false;
        }
        return true;
    }

    // 🧾 Prints the Sudoku board nicely in a grid format
    public void PrintBoard()
    {
        Console.WriteLine("\n🧩 Sudoku Board:");
        for (int r = 0; r < Size; r++)
        {
            for (int c = 0; c < Size; c++)
            {
                Console.Write(_matrix[r, c] == 0 ? ". " : _matrix[r, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
