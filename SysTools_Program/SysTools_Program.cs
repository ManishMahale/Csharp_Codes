using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace stringreverce
{
    public class Demo
    {
        static void Main()
        {
            Stopwatch sw1 = Stopwatch.StartNew(); //to know time to complete operation
            sw1.Start();
            //int[,] a = new int[5, 5]; // to take inlut from user we declare 5X5 array

            int[,] a = new int[,] { { 1, 0, 1, 0, 1 }, { 0, 1, 1, 0, 1 }, { 1, 1, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 0, 0, 0, 1 } }; 
            int rows = a.GetLength(0);  // to find rows in 2d array
            int cols = a.GetLength(1); // to find columns in 2d array

            Console.WriteLine("rows " + rows + "  " + "cols " + cols);

            int zcount = 0, ocount = 0;
            try
            {
                //Console.WriteLine("Enter 25 elements:");
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        a[i, j] = int.Parse(Console.ReadLine()); // user input
                //    }
                //}
                Console.WriteLine("\n2D Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(a[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nEnter Location of Cell in the Array: ");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == x && j == y)
                        {
                            if (i == 0 && j == 0)
                            {
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j + 1] == 0)
                                {

                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if (i == 0 && j == 4)
                            {
                                if (a[i, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if (i == 4 && j == 0)
                            {
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if (i == 4 && j == 4)
                            {
                                if (a[i, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if (i == 0 && (j == 1 || j == 2 || j == 3))
                            {
                                if (a[i, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if ((i == 1 || i == 2 || i == 3) && j == 0)
                            {
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if (i == 4 && (j == 1 || j == 2 || j == 3))
                            {
                                if (a[i, j - 1] == -0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if ((i == 1 || i == 2 || i == 3) && j == 4)
                            {
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }

                            if ((i == 1 || i == 2 || i == 3) && (j == 1 || j == 2 || j == 3))
                            {
                                if (a[i, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i + 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j + 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    zcount++;
                                }
                                if (a[i - 1, j] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                                if (a[i - 1, j - 1] == 0)
                                {
                                    zcount++;
                                }
                                else
                                {
                                    ocount++;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Count of Zero = " + zcount + "\n" + "Count of One = " + ocount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw1.Stop();
                Console.WriteLine("\nTime Taken to Complete the tast " + sw1.ElapsedMilliseconds+" milisecond"); //sw1.ElapsedMilliseconds -> to print time in milisecond on console
            }
        }
    }
}

/*
    rows 5  cols 5

 input:

    2D Array:

    1  0  1  0  1
    0  1  1  0  1
    1  1  1  0  1
    1  0  1  1  1
    1  0  0  0  1

    Enter Location of Cell in the Array:
    2
    2

output:

    Count of Zero = 3
    Count of One = 5

    Time Taken to Complete the Test: 14126 miliseconds

 */