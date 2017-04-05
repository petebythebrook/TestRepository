using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Exercise_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortList;
            
            BubbleSortUserInterface bubbleSortIF = new BubbleSortUserInterface( );

            int numDataItemsInput = bubbleSortIF.gatherDataToSort( out sortList );

            bubbleSortIF.displayDataToSort(ref sortList);

            BubbleSort_ bubbleSort = new BubbleSort_();

            bubbleSort.doSort(ref sortList, numDataItemsInput);

            bubbleSortIF.displaySortedData(ref sortList);
        }
    }

    public class BubbleSort_
    {
         public void doSort(ref int[] sortList, int numElements)
         {
             int t;
             int loops = 0;
             bool swap = false;
             for (int i = 0; i < numElements; i++)
             {
                for (int j = 0; j < (numElements - i - 1); j++)
                {
                    swap = false;
                    //If the current element is greater than the next swap positions
                    if (sortList[j] > sortList[j + 1])
                    {
                        swap = true;
                        t = sortList[j];
                        sortList[j] = sortList[j + 1];
                        sortList[j + 1] = t;
                    }
                    loops++;
                    if (swap == false)
                        break;
                }
            }
             Console.WriteLine("/nLoops = {0}/n", loops);
        }
    }

    public class BubbleSortUserInterface
    {
        public int  numElements = 0;
        int         userInput;
        const int   MAXDATA = 100;

        public BubbleSortUserInterface()
        {
            Console.WriteLine("Input Data to Sort, one item per line \n");
            Console.WriteLine("Terminate input with a 0 \n\n");
        }

        public int gatherDataToSort(out int[] sortList)
        {
             sortList = new int[MAXDATA];
             while ((userInput = Convert.ToInt32(Console.ReadLine())) != 0 && numElements < MAXDATA)
                sortList[numElements++] = userInput;
             return numElements;
        }

        public void displayDataToSort(ref int[] sortList)
        {
            Console.WriteLine("Data to Sort... \n");

            for (int i = 0; i < numElements; i++)
                Console.Write("{0},", sortList[i]);

            Console.WriteLine("\n");
        }

        public void displaySortedData(ref int[] sortList)
        {
            Console.WriteLine("Sorted Data... \n");

            for (int i = 0; i < numElements; i++)
                Console.Write("{0},", sortList[i]);

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
