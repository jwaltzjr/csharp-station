using System;

class Matrix
{
    public static Random m_rand = new Random();
    public const int DimSize = 3;
    private double[,] m_matrix = new double[DimSize, DimSize];

    public double this[int x, int y]
    {
        get
        {
            return m_matrix[x, y];
        }
        set
        {
            m_matrix[x, y] = value;
        }
    }

    public static Matrix operator + (Matrix mat1, Matrix mat2)
    {
        Matrix resultMatrix = new Matrix();

        for (int x=0; x < DimSize; x++)
        {
            for (int y=0; y < DimSize; y++)
            {
                resultMatrix[x, y] = mat1[x, y] + mat2[x, y];
            }
        }

        return resultMatrix;
    }

    public void Init()
    {
        for (int x=0; x < Matrix.DimSize; x++)
        {
            for (int y=0; y < Matrix.DimSize; y++)
            {
                this[x, y] = m_rand.NextDouble();
            }
        }
    }

    public void Print()
    {
        Console.WriteLine();

        for (int x=0; x < Matrix.DimSize; x++)
        {
            Console.Write("[ ");

            for (int y=0; y < Matrix.DimSize; y++)
            {
                // format the output
                Console.Write("{0,8:#.000000}", this[x, y]);

                if ( y < Matrix.DimSize - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(" ]");
        }

        Console.WriteLine();
    }

}

class MatrixTest
{

    static void Main()
    {
        Matrix firstMatrix = new Matrix();
        Matrix secondMatrix = new Matrix();

        firstMatrix.Init();
        secondMatrix.Init();
        Matrix thirdMatrix = firstMatrix + secondMatrix;

        Console.WriteLine("firstMatrix");
        firstMatrix.Print();

        Console.WriteLine("secondMatrix");
        secondMatrix.Print();

        Console.WriteLine("firstMatrix + secondMatrix = ");
        thirdMatrix.Print();
    }

}