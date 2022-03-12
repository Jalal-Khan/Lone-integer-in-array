using System;

namespace LoneInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 3, 2, 1, 4, 5 };
            int loneInt = int.MinValue;
            if (a.Length > 1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        // if same element for both
                        if (i == j)
                        {
                            if (j == a.Length - 1)
                            {
                                // assign lone value

                                loneInt = a[i];
                                goto endLoop;
                            }
                            else
                                continue;
                        }
                        // is value is matched
                        else if (a[i] == a[j])
                        {
                            break;
                        }
                        else if (j == a.Length - 1)
                        {
                            loneInt = a[i];
                        }// end else
                    }// end for j
                }// end for i
            }
            else if (a.Length == 1)
            {
                loneInt = a[0];
            }
            endLoop:
            Console.WriteLine(loneInt);

        }

    }
}