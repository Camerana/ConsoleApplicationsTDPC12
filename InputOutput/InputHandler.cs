using System;

namespace ConsoleApplicationsTDPC12.InputOutput
{
    public class InputHandler : IGetInput
    {
        public string Input { get; set; }
        public void GetInput()
        {
            Console.WriteLine("Inserisci un input");
            this.Input = Console.ReadLine();
        }
    }
}