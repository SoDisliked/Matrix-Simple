using System;
public class Exercise19
{
    public static void Main()
    {
        int i, j, k;
        int[,] arr 1 = new int[20, 20];
        int[,] arr 2 = new int[20, 20];
        int[,] arr 3 = new int[20, 20];
        // setting matrix row and columns size 

    private int width;
    private int height;

    public float Data[];

    public Matrix(int width, int height)
    {
        this.height = height;
        this.width = width;
    }

    Data = new float[height[]];
            for (int i = 0; i<height; i++)
            {
                Data[i] = new float[width];
                for (int j = 0; j<width; i++)
                {
                    Data[i] = 0f;
                }
            }

n = 3;
Console.WriteLine("Enter elements in the first matrix:/n");
for (int i = 0, i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("/nFirstMatrix is:/n");
for (i = 0; i < n; ++)
{
    Console.Write("/n");
    for (j = 0; j < n; j++)
        Console.Write("{0]/t", arr2[i, j]);
}
for (i = 0; i < n; i++)
    for (j = 0; j < n; j++)
        arr3[i, j] = arr1[i, j] + arr2[i, j];
Console.Write("\nAdding two matrices: \n");
for (i = 0; i < n; i++)
{
    Console.Write("\n");
    for (j = 0; j < n; j++)
        Console.Write("{0}\t", arr3[i, j]);
}
Console.Write("\n\n");
  }
}