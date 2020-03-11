using System;

namespace Calculator
{
    public abstract class InstructionBase
    {
        public float Number { get; set; }

        public InstructionBase() { }
        public abstract float Execute(float number);
    }

    public class AddOper : InstructionBase
    {
        public override float Execute(float number)
        {
            return number + this.Number;
        }
    }
    public class SubstractOper : InstructionBase
    {
        public override float Execute(float number)
        {
            return number - this.Number;
        }
    }
    public class MultiplyOper : InstructionBase
    {
        public override float Execute(float number)
        {
            return number * this.Number;
        }
    }
    public class DivideOper : InstructionBase
    {
        public override float Execute(float number)
        {
            return number / this.Number;
        }
    }
    public class ApplyOper : InstructionBase
    {
        public override float Execute(float number)
        {
            throw new NotSupportedException();
        }
    }
}
