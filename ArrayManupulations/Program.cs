using System;
using System.Buffers;
using System.Linq;

namespace ArrayManupulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArr = Console.ReadLine().Split().
                Select(int.Parse).ToArray();

            String comm = Console.ReadLine();
            while(comm != "end")
            {
                if(comm == "max even" || comm == "max odd" || comm == "min even"|| comm == "min odd")
                {
                    int index = MaxOrMinEvenOrOddElement(userArr, comm);
                    if(index != -1)
                    {
                        Console.WriteLine(index);
                    }
                }
                else
                {
                    string[] commands = comm.Split();
                    if (commands[0] == "exchange")
                    {
                        int[] exchangedArray = Exchange(userArr, int.Parse(commands[1]));
                        if(exchangedArray != null)
                        {
                            userArr = exchangedArray;
                        }
                    }
                    else if((commands[0] == "first" || commands[0] == "last") && (commands[2] == "even" || commands[2] == "odd"))
                    {
                        int[] result = FirstOrLastCountEvenOrOddElements(userArr, int.Parse(commands[1]), commands[0], commands[2]);
                        if(result != null)
                        {
                            Console.WriteLine($"[{String.Join(", ",result)}]");
                        }
                     }
                }
                comm = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", userArr)}]");
        }


        static int[] FirstOrLastCountEvenOrOddElements(int[] arr, int count, string firstOrLast, string evenOrOdd) //If the count is out Of boundaries, returns null. 
        {
            if(count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return null;
            }
            int lastValidIndex = 0; // At the end if it's still zero, there are no elements which satisfy the condition
            int[] result = new int[count];
            if(firstOrLast == "first")
            {
                if(evenOrOdd == "even") 
                {
                    for(int i = 0; i <arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            result[lastValidIndex++] = arr[i];
                        }
                        if (lastValidIndex == count)
                        {
                            break;
                        }
                    }
                }
                else if(evenOrOdd == "odd")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1)
                        {
                            result[lastValidIndex++] = arr[i];
                        }
                        if(lastValidIndex == count)
                        {
                            break;
                        }
                    }
                }
            }
            else if(firstOrLast == "last")
            {
                if (evenOrOdd == "even")
                {
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            result[lastValidIndex++] = arr[i];
                        }
                        if (lastValidIndex == count)
                        {
                            break;
                        }
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (arr[i] % 2 == 1)
                        {
                            result[lastValidIndex++] = arr[i];
                        }
                        if (lastValidIndex == count)
                        {
                            break;
                        }
                    }
                }
                
            }
            if(lastValidIndex == 0)
            {
                Console.WriteLine("[]");
                return null;
            }
            else
            {
                int[] finalResult = new int[lastValidIndex];
                if(firstOrLast == "last")
                {
                    for (int i = 0; i < lastValidIndex; i++)
                    {
                        finalResult[i] = result[lastValidIndex - i - 1];
                    }
                    
                }
                else
                {
                    for (int i = 0; i < lastValidIndex; i++)
                    {
                        finalResult[i] = result[i];
                    }
                    
                }
                return finalResult;
            }

           
        }

        static int[] Exchange(int[] arr, int index) //Returns the exchanged array. If index is out of boundaries, returns null
        {
            if(index >= arr.Length || index < 0)
            {
                Console.WriteLine("Invalid index");
                return null; 
            }
            int[] arr1 = new int[index + 1];
            for(int i = 0; i <= index; i++)
            {
                arr1[i] = arr[i];
            }
            int[] arr2 = new int[arr.Length - index - 1];
            for(int i = 0; i < arr.Length - index - 1; i++) 
            {
                arr2[i] = arr[i + index + 1];
            }
            for(int i = 0; i < arr2.Length; i++)
            {
                arr[i] = arr2[i];
            }
            for(int i = 0; i < arr1.Length; i++)
            {
                arr[i + arr2.Length] = arr1[i];
            }

            return arr;
        }

        static int MaxOrMinEvenOrOddElement(int[] arr, string com) //returns max or min even or odd element of array. Returns -1 if not found
        {
            int index = -1;
            string[] commands = com.Split();
            if (commands[0] == "max")
            {
                int max = 0;
                if (commands[1] == "even")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            if (arr[i] >= max)
                            {
                                max = arr[i];
                                index = i;
                            }
                        }
                    }
                }
                else if(commands[1] == "odd"){

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1)
                        {
                            if (arr[i] >= max)
                            {
                                max = arr[i];
                                index = i;
                            }
                        }
                    }
                }
            }
            else if(commands[0] == "min")
            {
                int min = arr[0];
                if (commands[1] == "even")
                {

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            if (min % 2 != 0)
                            {
                                min = arr[i];
                                index = i;
                            }
                            if (arr[i] <= min)
                            {
                                min = arr[i];
                                index = i;
                            }
                        }
                    }
                }
                else if (commands[1] == "odd")
                {
                    
                    for (int i = 0; i < arr.Length; i++)
                    {

                        if (arr[i] % 2 == 1)
                        {
                            if (min % 2 == 0)
                            {
                                min = arr[i];
                                index = i;
                            }
                            if (arr[i] <= min)
                            {
                                min = arr[i];
                                index = i;
                            }
                        }
                    }
                }
            }
            if(index == -1)
            {
                Console.WriteLine("No matches");
            }
            return index;
        }

    }
}
