using System.Collections.Generic;
using Algorithms.Sort;
using System;
using Xunit;

namespace Algorithms.Test.Sort
{
    public class BinarySortTest
    {
        private BinarySort _algorithm {get;set;} = new BinarySort();

        [Fact]       
        public void Find()
        {
            var data = new int[100];

            for (var i = 0; i < 100; i++)
                data[i] = i;                
                        
            var valueToFind = 77;
            var position = _algorithm.FindIndex(data, valueToFind);
            
            Assert.Equal(77, position);

        }
    }
}