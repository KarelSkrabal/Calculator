using FileHelpers;

namespace Calculator
{
    [DelimitedRecord (" ")]
    [IgnoreEmptyLines]
    public class Instruction
    {
        public string Keyword { get; set; }
        public int Number { get; set; }

        public Instruction() { }

        public Instruction(string keyword, int number)
        {
            Keyword = keyword;
            Number = number;
        }

        public Instruction(Instruction input) : this(input.Keyword, input.Number) { }
    }
}
