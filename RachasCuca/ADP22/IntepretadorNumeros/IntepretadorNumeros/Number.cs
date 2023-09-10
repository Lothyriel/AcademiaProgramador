using System;
using System.Text;

namespace IntepretadorNumeros
{
    public class Number
    {
        public Number(StringBuilder upperPart, StringBuilder middlePart, StringBuilder lowerPart)
        {
            UpperPart = upperPart.Replace(' ', 'X');
            MiddlePart = middlePart.Replace(' ', 'X');
            LowerPart = lowerPart.Replace(' ', 'X');
        }
        public Number(Number number)
        {
            UpperPart = number.UpperPart.Replace('X', ' ');
            MiddlePart = number.MiddlePart.Replace('X', ' ');
            LowerPart = number.LowerPart.Replace('X', ' ');
        }

        public StringBuilder UpperPart { get; }
        public StringBuilder MiddlePart { get; }
        public StringBuilder LowerPart { get; }

        public int ToInteger()
        {
            var representation = ToString("");
            return representation switch
            {
                "X||" => 1,
                "X__XX__||__X" => 2,
                "__X__|__|" => 3,
                "XXXX|__|XXX|" => 4,
                "X__X|__XX__|" => 5,
                "X__X|__X|__|" => 6,
                "__XXX|XX|" => 7,
                "X__X|__||__|" => 8,
                "X__X|__|X__|" => 9,
                "X__X|XX||__|" => 0,
                _ => throw new Exception("Invalid number format"),
            };
        }
        public string ToString(string separator)
        {
            return $"{UpperPart}{separator}{MiddlePart}{separator}{LowerPart}";
        }
        public override string ToString()
        {
            return ToString("\n");
        }
    }
}