using NUnit.Framework;

namespace XpSudoku
{
    [TestFixture]
    public class SudokuTests
    {
        [Test]
        public void IsRowValid()
        {
            Assert.That(SudokuFunction.IsRowValid(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }) == true);
        }

        [Test]
        public void sample()
        {
            var solvedPuzzle = @"
1 3 4 9 5 6 7 8 2
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
