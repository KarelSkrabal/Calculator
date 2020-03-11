using System;
using System.Collections.Generic;

namespace Calculator
{
    class Parser
    {
        private List<Instruction> Instructions;

        public Parser(Instruction[] instractions)
        {
            this.Instructions = new List<Instruction>(instractions);
        }

        public List<InstructionBase> parse()
        {
            List<InstructionBase> ret = new List<InstructionBase>();

            InstructionBase x;
            foreach (Instruction instr in this.Instructions)
            {
                switch (instr.Keyword)
                {
                    case "add":
                        x = new AddOper() { Number = instr.Number };
                        break;
                    case "substract":
                        x = new SubstractOper() { Number = instr.Number };
                        break;
                    case "multiply":
                        x = new MultiplyOper() { Number = instr.Number };
                        break;
                    case "divide":
                        x = new DivideOper() { Number = instr.Number };
                        break;
                    case "apply":
                        x = new ApplyOper() { Number = instr.Number };
                        break;
                    default:
                        throw new Exception("Instruction " + instr.Keyword + " is not valid. Only add/substract/multiply/divide/apply instruction is allowed.");
                }
                ret.Add(x);
            }

            return ret;
        }
    }
}
