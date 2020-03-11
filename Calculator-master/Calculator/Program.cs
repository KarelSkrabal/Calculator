using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo path = new FileInfo(args[0]);
            if (!path.Exists)
                throw new FileNotFoundException("file " + path.FullName + " was not found.");

            FileReader fileReader = new FileReader(args[0]);

            Parser parser = new Parser(fileReader.Readfile());

            Calculator calculator = new Calculator(parser.parse());

            Console.WriteLine(calculator.Calculate());

            Console.ReadKey();
        }
    }
}
