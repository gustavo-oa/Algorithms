using System;

namespace Algorithms.Sort
{
    public class BinarySort
    {
        public int FindIndex(int[] data, int value)
        {
            return FindIndex(data, value, 0, data.Length);
        }

        private int FindIndex(int[] data, int value, int start, int end) 
        {
            if (end < start)
                return -1;
            
            var mid = start + (end- start) / 2;
            
            if (data[mid] == value) 
                return mid;

            if (data[mid] > value) 
                return FindIndex(data, value, start, mid -1);
            
            return FindIndex(data, value, mid +1, end);
        }
    }
}