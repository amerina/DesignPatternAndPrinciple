﻿using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SortedList
    {
        private List<string> List = new List<string>();
        private ISortStrategy SortStrategy;

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            this.SortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            List.Add(name);
        }

        public void Sort()
        {
            SortStrategy.Sort(List);

            // Iterate over list and display results
            foreach (string name in List)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
