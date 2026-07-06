using System;

namespace FactoryMethodPatternExample
{
    public class ExcelDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening Excel document...");
        public void Save() => Console.WriteLine("Saving Excel document...");
    }
}