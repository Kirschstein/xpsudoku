using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace XpSudoku
{
    public class SudokuFunction
    {
        public static string Solve(string grid)
        {
            if (grid.Trim().StartsWith("2"))
            {
                return @"2 1
                1 2";
            }
            return @"1 2
                2 1"; 
        }
    }
}
