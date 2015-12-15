using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day1 : IDay
    {
        private readonly IDictionary<char, int> _incrementor = new Dictionary<char, int>
        {
            {'(', 1 },
            {')', -1 }
        }; 
        public string Run(string input)
        {
            var floor = input.Sum(t => _incrementor[t]);
            return floor.ToString();
        }
    }
}
