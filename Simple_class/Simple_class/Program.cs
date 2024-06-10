using System;

public class ThreeDimensionalArray
{
    private int[,,] array;

    public ThreeDimensionalArray(int x, int y, int z)
    {
        array = new int[x, y, z];
    }

    public int GetLength(int dimension)
    {
        if (dimension < 0 || dimension > 2)
        {
            throw new ArgumentOutOfRangeException(nameof(dimension), "Dimension must be between 0 and 2.");
        }
        return array.GetLength(dimension);
    }

    public void FillArray(int value)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = value;
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ThreeDimensionalArray myArray = new ThreeDimensionalArray(3, 4, 5);

        Console.WriteLine("Length in dimension 0: " + myArray.GetLength(0)); 
        Console.WriteLine("Length in dimension 1: " + myArray.GetLength(1)); 
        Console.WriteLine("Length in dimension 2: " + myArray.GetLength(2));
    }
}
