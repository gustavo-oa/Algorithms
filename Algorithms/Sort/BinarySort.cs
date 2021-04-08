using System;

namespace Algorithms.Sort
{
    public class BinarySort
    {
        public int Find(int[] data, int value)
        {
            return Find(data, value, 0, data.Length);
        }

        private int Find(int[] data, int value, int start, int end) 
        {
            if (end < start)
                return -1;
            
            var mid = start + (end- start) / 2;
            
            if (data[mid] == value) 
                return mid;

            if (data[mid] > value) 
                return Find(data, value, start, mid -1);
            
            return Find(data, value, mid +1, end);
        }
    }
}