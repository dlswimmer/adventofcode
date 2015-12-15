using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day4
    {
        public string Run()
        {
            var md5 = MD5.Create();
            for (int i = 1;; i++)
            {
                var hash = md5.ComputeHash(Encoding.Default.GetBytes(Input + i));
                if (hash.Length >= 3 && hash[0] == 0 && hash[1] == 0 && hash[2] < 16)
                {
                    return i.ToString();
                }
            }
        }
        public string Runb()
        {
            var md5 = MD5.Create();
            for (int i = 1; ; i++)
            {
                var hash = md5.ComputeHash(Encoding.Default.GetBytes(Input + i));
                if (hash.Length >= 3 && hash[0] == 0 && hash[1] == 0 && hash[2] == 0)
                {
                    return i.ToString();
                }
            }
        }
        public const string Input = "yzbqklnj";
    }
}
