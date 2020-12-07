using System;

public class Matrix
{
    private int noOfRow; //number of rows for matrix
    private int noOfColumn; //number of colums for matrix
    private double[,] matrix; //holds values of matrix itself

    //create row*column matrix and fill it with data passed to this constructor
    public Matrix(double[,] double_array)
    {
        matrix = double_array;
        noOfRow = matrix.GetLength(0);
        noOfColumn = matrix.GetLength(1);
        Console.WriteLine("Constructor which sets matrix size {0}*{1} and fill it with initial data executed.", noOfRow, noOfColumn);
    }
    //returns total number of rows
    public int countRows()
    {
        return noOfRow;
    }

    //returns total number of columns
    public int countColumns()
    {
        return noOfColumn;
    }

    //returns value of an element for a given row and column of matrix
    public double readElement(int row, int column)
    {
        return matrix[row, column];
    }

    //sets value of an element for a given row and column of matrix
    public void setElement(double value, int row, int column)
    {
        matrix[row, column] = value;
    }

    // method to calculate the determine of any square of matrices
    public double deterMatrix()
    {
        try
        {
            double determinantValue = 0;
            double value = 0;
            int i, j, k;

            i = noOfRow;
            j = noOfColumn;
            int n = i;

            if (i != j)
            {
                Console.WriteLine("determinant can be calculated only for sqaure matrix!");
                return determinantValue;
            }

            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    determinantValue = (this.readElement(j, i) / this.readElement(i, i));

                    for (k = i; k < n; k++)
                    {
                        value = this.readElement(j, k) - determinantValue * this.readElement(i, k);

                        this.setElement(value, j, k);
                    }
                }
            }
            determinantValue = 1;
            for (i = 0; i < n; i++)
                determinantValue = determinantValue * this.readElement(i, i);

            return determinantValue;
        }
        catch (Exception)
        {

            throw;
        }
        
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Matrix mat02 = new Matrix(new[,]
        {
            {2.0, 3.0},
            {3.0, 5.0},
        });

        Matrix mat03 = new Matrix(new[,]
        {
            {1.0, 2.0, -1.0},
            {-2.0, -5.0, -1.0},
            {1.0, -1.0, -2.0},
        });

        Matrix mat04 = new Matrix(new[,]
        {
            {1.0, 2.0, 1.0, 3.0},
            {-2.0, -5.0, -2.0, 1.0},
            {1.0, -1.0, -3.0, 2.0},
            {4.0, -1.0, -3.0, 1.0},
        });

        Matrix mat05 = new Matrix(new[,]
        {
            {1.0, -2.0, 1.0, 2.0, 3.0},
            {2.0, 1.0, 2.0, 2.0, -1.0},
            {-3.0, 1.0, 3.0, 1.0, 2.0},
            {1.0, 2.0, 4.0, -3.0, 2.0},
            {2.0, -2.0, 1.0, 2.0, 1.0},
        });

        Matrix mat06 = new Matrix(new[,]
        {
            {1.0, -2.0, 1.0, 2.0, 3.0, 2.0},
            {2.0, 1.0, 2.0, 2.0, -1.0, 2.0},
            {-3.0, 1.0, 3.0, 1.0, 2.0, 4.0},
            {1.0, 2.0, 4.0, -3.0, 2.0, 3.0},
            {2.0, -2.0, 1.0, 2.0, 1.0, 3.0},
            {2.0, 3.0, 4.0, -3.0, 2.0, 1.0 }
        });

        double determinant = mat02.deterMatrix();
        Console.WriteLine("determinant is : {0}", determinant);

        determinant = mat03.deterMatrix();
        Console.WriteLine("determinant is: {0}", determinant);

        determinant = mat04.deterMatrix();
        Console.WriteLine("determinant is: {0}", determinant);

        determinant = mat05.deterMatrix();
        Console.WriteLine("determinant is: {0}", determinant);

        determinant = mat06.deterMatrix();
        Console.WriteLine("determinant is: {0}", determinant);
        Console.ReadLine();
    }
}