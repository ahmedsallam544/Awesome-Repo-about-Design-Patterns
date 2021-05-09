using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatternsCSharp.Behavioral
{
    interface SortStrategy
    {
        Array sort(Array dataset);
    }

    class BubbleSortStrategy : SortStrategy
    {
        public Array sort(Array dataset)
        {
            Console.WriteLine("Sorting using bubble sort");
            // Do sorting
            return dataset;
        }
    }

    class QuickSortStrategy : SortStrategy
    {
        public Array sort(Array dataset)
        {
            Console.WriteLine("Sorting using quick sort");
            // Do sorting
            return dataset;
        }
    }

    // And then we have our client that is going to use any strategy
    class Sorter
    {
        protected SortStrategy sorter;

        public Sorter(SortStrategy sorter)
        {
            this.sorter = sorter;
        }
        public Array sort(Array dataset)
        {
            return this.sorter.sort(dataset);
        }
    }
    class Strategy
    {

        //static void Main(string[] args)
        //{
        //    int[] dataset = { 1, 5, 4, 3, 2, 8 };
        //    Sorter sorter = new Sorter(new BubbleSortStrategy());
        //    sorter.sort(dataset); // Output : Sorting using bubble sort

        //    sorter = new Sorter(new QuickSortStrategy());
        //    sorter.sort(dataset); // Output : Sorting using quick sort
        //}

    }
}