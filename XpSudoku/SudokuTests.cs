using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace XpSudoku
{
    [TestFixture]
    public class SudokuTests
    {
        [Test]
        public void TwoByTwoUnchanged()
        {
            var inputAndExpectedOutput = @"
                1 2
                2 1";

            var output = SudokuFunction.Solve(inputAndExpectedOutput);

            Assert.That(output, Is.EqualTo(inputAndExpectedOutput));
        }

        [Test]
        public void TwoByTwoSolved()
        {
            var input = @"
                - 2
                2 1";
            var expectedOutput = @"
                1 2
                2 1";

            var output = SudokuFunction.Solve(input);

            Assert.That(output, Is.EqualTo(expectedOutput));
        }
        
        public void sample()
        {

            var fourbyFour1 = @"
? 1 2 3
3 2 4 1
1 4 3 2
2 3 1 4";

            var unsolvedPuzzle = @"
? 3 4 9 5 6 7 8 2
2 5 6 1 7 8 3 4 9
7 8 9 2 3 4 1 5 6
3 1 2 4 6 5 8 9 7
5 4 8 7 1 9 2 6 3
6 9 7 3 8 2 4 1 5
8 2 1 5 9 3 6 7 4
9 6 3 8 4 7 5 2 1
4 7 5 6 2 1 9 3 8
";
        }
    }
}
