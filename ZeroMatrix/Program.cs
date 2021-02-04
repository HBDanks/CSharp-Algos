using System;

namespace ZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] test1 = {
                {true, false, false},
                {false, false, false},
                {false, true, false},

            };

            bool[,] zeroed = ZeroMatrix(test1);

            for(int i = 0; i < zeroed.GetLength(1); i++)
            {
                string row = "[";
                for(int j = 0; j < zeroed.GetLength(0); j++)
                {
                    row += zeroed[i,j].ToString() + ", ";
                }
                row += "]";
                Console.WriteLine(row);
            }

        }
        static bool[,] ZeroMatrix(bool[,] matrix)
        {
            // M is the height of the matrix, N is the width of the matrix
            int M = matrix.GetLength(0);
            int N = matrix.GetLength(1);
            bool rowTrue = false;
            bool colTrue = false;

            // Check to see if any values in the top row or left col are true
            // we change the rowTrue or colTrue so that we can later modify the first row and column
            for(int i = 0; i < M; i++)
            {
                if(matrix[i,0] == true)
                {
                    colTrue = true;
                    break;
                }
            }

            for(int i = 0 ; i < N; i++)
            {
                if(matrix[0,i] == true)
                {
                    rowTrue = true;
                    break;
                }
            }

            // if we use the top row and left colum as identifiers for the other columns value
            // we can later see all of the rows and columns that should be true
            for(int i = 1; i < M; i++)
            {
                for(int j = 1; j < N; j++)
                {
                    if(matrix[i,j] == true)
                    {
                        matrix[0,j] = true;
                        matrix[i,0] = true;
                    }
                }
            }

            for(int i = 1; i < M; i++)
            {
                for(int j = 1; j < N; j++)
                {
                    if(matrix[i,0] == true || matrix[0,j] == true)
                    {
                        matrix[i,j] = true;
                    }
                }
            }

            if(rowTrue == true)
            {
                for(int i = 0; i < N; i++)
                {
                    matrix[0,i] = true;
                }
            }

            if(colTrue == true)
            {
                for(int i = 0; i < M; i++)
                {
                    matrix[i,0] = true;
                }
            }
            return matrix;
        }
    }
}
