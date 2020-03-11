using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddInstruction()
        {
            var testAddOper = new AddOper();
            testAddOper.Number = 3;
            var testApply = new ApplyOper();
            testApply.Number = 4;

            var testInstructions = new List<InstructionBase>();
            testInstructions.Add(testAddOper);
            testInstructions.Add(testApply);
            var testCalculator = new Calculator(testInstructions);

            Assert.AreEqual(7, testCalculator.Calculate());
        }

        [TestMethod]
        public void TestSubstractInstruction()
        {
            var testSubstractOper = new SubstractOper();
            testSubstractOper.Number = 3;
            var testApply = new ApplyOper();
            testApply.Number = 4;

            var testInstructions = new List<InstructionBase>();
            testInstructions.Add(testSubstractOper);
            testInstructions.Add(testApply);
            var testCalculator = new Calculator(testInstructions);

            Assert.AreEqual(1, testCalculator.Calculate());
        }

        [TestMethod]
        public void TestMultiplyInstruction()
        {
            var testMultiplyOper = new MultiplyOper();
            testMultiplyOper.Number = 3;
            var testApply = new ApplyOper();
            testApply.Number = 4;

            var testInstructions = new List<InstructionBase>();
            testInstructions.Add(testMultiplyOper);
            testInstructions.Add(testApply);
            var testCalculator = new Calculator(testInstructions);

            Assert.AreEqual(12, testCalculator.Calculate());
        }

        [TestMethod]
        public void TestDivideInstruction()
        {
            var testDivideOper = new DivideOper();
            testDivideOper.Number = 2;
            var testApply = new ApplyOper();
            testApply.Number = 4;

            var testInstructions = new List<InstructionBase>();
            testInstructions.Add(testDivideOper);
            testInstructions.Add(testApply);
            var testCalculator = new Calculator(testInstructions);

            Assert.AreEqual(2, testCalculator.Calculate());
        }
    }
}
