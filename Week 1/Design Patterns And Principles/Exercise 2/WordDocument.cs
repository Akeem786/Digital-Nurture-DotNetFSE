using System;

namespace FactoryMethodPatternExample
{
    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Word document...");
        public void Save() => Console.WriteLine("Saving Word document...");
    }
}