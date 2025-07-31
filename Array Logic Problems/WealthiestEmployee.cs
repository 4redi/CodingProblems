using System;
using System.Collections.Generic;
 public class Problems
{
    public static void TwoDimensionalArrays()
    {
        int[,] employees = { { 100, 200, 300 },
                            { 400, 500, 600 } };
        int sum = 0;
        int max = employees[0,0];
        int min = employees[0,0];
        for (int i = 0; i < employees.GetLength(0); i++)
        {
            for (int j = 0; j < employees.GetLength(1); j++)
            {
                sum += employees[i, j];
                int val = employees[i, j];
                if (max < val)
                {
                    max = val;
                }
                if (min > val)
                {
                    min = val;
                }
            }
        }
        Console.WriteLine($"Sum is {sum}");
        Console.WriteLine($"{min}, {max}");

    }
}
