using System;

class Program
{
    static void Main()
    {
        // ==============================
        // 🔹 IP CLASS DEMO
        // ==============================
        Console.WriteLine("=== IP CLASS DEMO ===");

        try
        {
            // Create IP object using integer constructor
            IP firstIP = new IP(192, 168, 45, 12);
            Console.WriteLine($"First IP Address: {firstIP}");

            // Get a segment by index
            int firstSegment = firstIP[0];
            Console.WriteLine($"First segment: {firstSegment}");

            // Create IP object using string constructor
            IP secondIP = new IP("192.168.55.47");
            Console.WriteLine($"Second IP Address: {secondIP}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.Message}");
        }

        Console.WriteLine("\n---------------------------------\n");

        // ==============================
        // 🔹 SUDOKU CLASS DEMO
        // ==============================
        Console.WriteLine("=== SUDOKU CLASS DEMO ===");

        // Ready-to-use Sudoku solution matrix
        int[,] input = new int[,]
        {
            {5,3,4,6,7,8,9,1,2},
            {6,7,2,1,9,5,3,4,8},
            {1,9,8,3,4,2,5,6,7},
            {8,5,9,7,6,1,4,2,3},
            {4,2,6,8,5,3,7,9,1},
            {7,1,3,9,2,4,8,5,6},
            {9,6,1,5,3,7,2,8,4},
            {2,8,7,4,1,9,6,3,5},
            {3,4,5,2,8,6,1,7,9}
        };

        Sudoku sudoku = new Sudoku(input);

        // ✅ Valid case
        sudoku[4, 4] = 5;
        Console.WriteLine($"Value at [4,4]: {sudoku[4, 4]}");

        // ⚠️ Invalid value (greater than 9)
        sudoku[0, 0] = 15;

        // ⚠️ Invalid index (out of range)
        sudoku[9, 0] = 3;

        // Print the Sudoku board
        sudoku.PrintBoard();

        Console.ReadKey();
    }
}
