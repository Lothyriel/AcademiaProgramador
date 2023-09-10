using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntepretadorNumeros
{
    public class Interpreter
    {
        public const int NumberHeight = 3;
        private const char WhiteSpace = ' ';

        public Interpreter(string input)
        {
            Lines = input.Split("\r\n");

            if (Lines.Any(l => l.Length != Lines[0].Length))
                throw new Exception("Lines don't have the same length!");

            if (Lines.Length > NumberHeight)
                throw new Exception("More lines than expected!");
        }

        public string[] Lines { get; }

        public int LineLenght => Lines[0].Length;

        public List<Number> SplitNumbers()
        {
            var numbers = new List<Number>();

            for (int i = 0; i < LineLenght; i++)
            {
                SkipBlankLines(ref i);
                numbers.Add(GetNumber(ref i));
            }
            return numbers;
        }
        public static int GetFullNumber(List<Number> ogNumbers)
        {
            var result = 0;
            var power = 0;

            foreach (var number in ogNumbers.Select(n => n.ToInteger()).Reverse())
                result += (int)(number * Math.Pow(10, power++));

            return result;
        }
        public static string PrintNumbers(List<Number> ogNumbers)
        {
            var sb = new StringBuilder();

            var numbers = ogNumbers.Select(n => new Number(n)).ToList();

            numbers.ForEach(n => sb.Append(n.UpperPart).Append(WhiteSpace));
            sb.AppendLine();
            numbers.ForEach(n => sb.Append(n.MiddlePart).Append(WhiteSpace));
            sb.AppendLine();
            numbers.ForEach(n => sb.Append(n.LowerPart).Append(WhiteSpace));

            return sb.ToString();
        }

        private Number GetNumber(ref int i)
        {
            var upperPart = new StringBuilder();
            var middlePart = new StringBuilder();
            var lowerPart = new StringBuilder();

            while (i < LineLenght && IsNotSeparator(ref i))
            {
                upperPart.Append(Lines[0][i]);
                middlePart.Append(Lines[1][i]);
                lowerPart.Append(Lines[2][i]);
                i++;
            }
            return new Number(upperPart, middlePart, lowerPart);

            bool IsNotSeparator(ref int i)
            {
                return new char[] { Lines[0][i], Lines[1][i], Lines[2][i] }.Any(l => l != WhiteSpace);
            }
        }

        private void SkipBlankLines(ref int i)
        {
            while (new char[] { Lines[0][i], Lines[1][i], Lines[2][i] }.All(l => l == WhiteSpace))
                i++;
        }
    }
}