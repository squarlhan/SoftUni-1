﻿using System;
using System.Collections.Generic;

namespace Problem1_ListlyIterator.Models.Generics
{
    public class ListlyIterator<T>
    {
        private int index;

        public ListlyIterator(IEnumerable<T> items)
        {
            this.Data = new List<T>();
            foreach (var item in items)
            {
                this.Data.Add(item);
            }
        }

        public IList<T> Data { get; private set; }

        public bool HasNext()
        {
            if ((this.index + 1) < this.Data.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (this.Data.Count > 0)
            {
                Console.WriteLine(this.Data[this.index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}