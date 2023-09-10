using FluentAssertions;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace IntepretadorNumeros
{
    public class UnitTest1
    {
        const string strNumbers = @"   __  __        __   __  __   __   __   __ 
|  __| __| |__| |__  |__    | |__| |__| |  |
| |__  __|    |  __| |__|   | |__|  __| |__|";

        [Fact]
        public void ShouldLoadSimplerString()
        {
            var input = @"1111 2222 3333 4444 5555 6666 7777 8888 9999
1111 2222 3333 4444 5555 6666 7777 8888 9999
1111 2222 3333 4444 5555 6666 7777 8888 9999";

            var numbers = new Interpreter(input).SplitNumbers();
            numbers.Should().HaveCount(9);

            var expected = Enumerable.Range(1, numbers.Count).Select(n => string.Concat(Enumerable.Repeat($"{n}{n}{n}{n}", 3)));
            numbers.Select(n => n.ToString("")).Should().ContainInOrder(expected);
        }
        [Fact]
        public void ShouldBe123456789()
        {
            var numbers = new Interpreter(strNumbers).SplitNumbers();

            var result = Interpreter.GetFullNumber(numbers);

            result.Should().Be(1234567890);
        }
        [Fact]
        public void ShouldPrintStrNumbers()
        {
            var numbers = new Interpreter(strNumbers).SplitNumbers();

            Debug.WriteLine(Interpreter.PrintNumbers(numbers));
        }
        [Fact]
        public void ShouldBe1()
        {
            var input = @" 
|
|";
            var numbers = new Interpreter(input).SplitNumbers();

            var one = numbers.First();

            one.ToInteger().Should().Be(1);
        }
    }
}