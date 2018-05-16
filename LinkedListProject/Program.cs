using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtStart("3");
            list.AddAtStart("5");
            list.AddAtStart("9");
            list.AddAtStart("0");
            list.AddToEnd("5");
            list.AddToEnd("1");
            list.AddToEnd("9");
            list.AddToEnd("0");

            list.PrintAllNodes();

            Console.WriteLine("---------------");
            Object o = "0";
            list.RemoveAll(o);

            list.PrintAllNodes();
            
            Console.WriteLine("---------------");

            Console.WriteLine("Find the frequency");

            int[] array = new int[100];
            int[] frequency = new int[100];
            int number, index, howMany, counter;


            
            Console.Write("\n\nCount the frequency of each element in the array:\n");
            Console.Write("----------------------------------------------------\n");

            Console.Write("Input how many elements you want to be stored:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} numbers:\n", number);
            //index=
            for (index = 0; index < number; index++)
            {
                Console.Write("element- {0} : ", index);
                array[index] = Convert.ToInt32(Console.ReadLine());
                frequency[index] = -1;
                
            }
            for (index = 0; index < number; index++)
            {
                counter = 1;
                for (howMany = index + 1; howMany < number; howMany++)
                {
                    if (array[index] == array[howMany])
                    {
                        counter++;
                        frequency[howMany] = 0;
                    }
                }

                if (frequency[index] != 0)
                {
                    frequency[index] = counter;
                }
            }
            Console.Write("\nThe frequency of all numbers: \n");
            for (index = 0; index < number; index++)
            {
                if (frequency[index] != 0)
                {
                    Console.Write("[{0}]: {1} time(s)\n", array[index], frequency[index]);
                }

            }


        }
    }
}
