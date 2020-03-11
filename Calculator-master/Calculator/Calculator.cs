using System.Collections.Generic;
using System.Linq;
using System;

namespace Calculator
{
    public class Calculator
    {
        private List<InstructionBase> Instructions { get; set; }

        public Calculator() { }

        public Calculator(List<InstructionBase> instructins) { Instructions = new List<InstructionBase>(instructins); }

        public float Calculate()
        {
            float ret = 0L;

            var lastInstruction = this.Instructions.Last();
            if (lastInstruction is AddOper)
                throw new Exception("There must be the apply instruction as the last instruction in the data file.");

            ret = lastInstruction.Number;

            foreach (var instr in this.Instructions.GetRange(0, this.Instructions.Count - 1))
                ret = instr.Execute(ret);

            return ret;
        }
    }
}
