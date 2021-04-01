using System;

namespace ConsoleApplicationsTDPC12.InputOutput
{
    public class OutputHandler : IPrintOutput
    {
        public string Output { get; set; }
        public OutputHandler(string input)
        {
            this.Output = input;
        }
        public void PrintOutput()
        {
            Console.WriteLine(this.Output);
        }
    }
}