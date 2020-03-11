using FileHelpers;

namespace Calculator
{
    class FileReader
    {
        private string PathToInput { get; set; }

        public FileReader(string pathToInput)
        {
            PathToInput = pathToInput;
        }

        public Instruction[] Readfile()
        {
            var engine = new FileHelperEngine<Instruction>();
            var lines = engine.ReadFile(PathToInput);

            return lines;
        }
    }
}
