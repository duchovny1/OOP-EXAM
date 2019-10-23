using System;
using System.Collections;
using System.Collections.Generic;

namespace Distance_In_Labyrinth
{
    class Program
    {
        static int startRow;
        static int startCol;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] eachRowOfMatrix = Console.ReadLine().ToCharArray();

                for (int j = 0; j < eachRowOfMatrix.Length; j++)
                {
                    matrix[i, j] = eachRowOfMatrix[j].ToString();

                    if (matrix[i, j] == "*")
                    {
                        startRow = i;
                        startCol = j;

                        matrix[i, j] = "0";
                    }
                }
            }

            Cell cell = new Cell(startRow, startCol);

            Queue<Cell> queue = new Queue<Cell>();

            queue.Enqueue(cell);



            while (queue.Count != 0)
            {
                Cell currentCell = queue.Dequeue();

                currentCell.visited = true;



                if (currentCell.row - 1 >= 0 && matrix[currentCell.row - 1, currentCell.col] == "0" )
                {
                    int newChar = int.Parse(matrix[currentCell.row, currentCell.col]) + 1;
                    
                    matrix[currentCell.row - 1, currentCell.col] = newChar.ToString();

                    queue.Enqueue(new Cell(currentCell.row - 1, currentCell.col));
                }

                if (currentCell.row + 1 < size && matrix[currentCell.row + 1, currentCell.col] == "0")
                {
                    int newChar = int.Parse(matrix[currentCell.row, currentCell.col].ToString()) + 1;
                    
                    matrix[currentCell.row + 1, currentCell.col] = newChar.ToString();

                    queue.Enqueue(new Cell(currentCell.row + 1, currentCell.col));
                }

                if (currentCell.col - 1 >= 0 && matrix[currentCell.row, currentCell.col - 1] == "0")
                {
                    int newChar = int.Parse(matrix[currentCell.row, currentCell.col].ToString()) + 1;
                    matrix[currentCell.row, currentCell.col - 1] = newChar.ToString();

                    queue.Enqueue(new Cell(currentCell.row, currentCell.col - 1));
                }

                if (currentCell.col + 1 < size && matrix[currentCell.row, currentCell.col + 1] == "0")
                {
                    int newChar = int.Parse(matrix[currentCell.row, currentCell.col].ToString()) + 1;
                    
                    matrix[currentCell.row, currentCell.col + 1] = newChar.ToString();

                    queue.Enqueue(new Cell(currentCell.row, currentCell.col + 1));
                }

                if(matrix[startRow, startCol] == "0")
                {
                    matrix[startRow, startCol] = "*";
                }
                
            }




            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == startRow && j == startCol)
                    {
                        Console.Write("*");
                        continue;
                    }
                    if (matrix[i, j] == "0")
                    {
                        Console.Write("u");
                        continue;
                    }

                   
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Cell
    {
       public int row { get; set; }
       public int col { get; set; }
       public bool visited { get; set; }

        public Cell(int row, int col, bool visited = false)
        {
            this.row = row;
            this.col = col;
        }

    }


}
