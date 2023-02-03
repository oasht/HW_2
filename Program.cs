using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string q;
            int digit;
            do
            {
                 
                Clear();
                WriteLine("Please choose the number of task\n");
                digit = Convert.ToInt32(ReadLine());
                switch (digit)
                {

                    case 1:
                        {
                            Clear();
                            string str;
                            WriteLine("Please enter your text\n");
                            str = ReadLine();
                            Write("\nModified to upper - ");
                            WriteLine(str.ToUpper());
                        }
                        break;
                    case 2:
                        {
                            Clear();
                            WriteLine("Please enter any number\n");
                            string s = ReadLine();
                            char[] str = s.ToCharArray();
                            Array.Reverse(str);
                            Write("\nReversed - ");
                            WriteLine(str);
                        }
                        break;
                        case 3:
                        {
                            Clear();
                            Random rand = new Random();
                            WriteLine("Please enter any number\n");
                            int a = Convert.ToInt32(ReadLine());

                            WriteLine("\nPlease enter any number bigger than the previous one\n");
                            int b = Convert.ToInt32(ReadLine());
                            int n = a;
                            int[][] arr = new int[b - a + 1][];
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = new int[a];
                                a++;
                            }

                            for (int i = 0; i < arr.Length; i++)
                            {

                                for (int j = 0; j < arr[i].Length; j++)
                                {
                                    arr[i][j] = n;
                                    Write(arr[i][j] + " ");

                                }
                                n++;
                                WriteLine();
                            }

                            WriteLine();

                        }
                        break;
                    default:
                        WriteLine("\nError!");
                        break;

                }
                Thread.Sleep(3000);
                Clear();
                WriteLine("Press 1 to continue");
                q = ReadLine();
                Clear();
            } while (q == "1");






        }
    }
}
