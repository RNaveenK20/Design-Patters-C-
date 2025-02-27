using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Pattern
{
    public interface IDocument
    {
        void Open();
    }

    public class PDFDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening a PDF document");
    }

    public class WordDocument : IDocument
    {
        public void Open() => Console.WriteLine("Opening a Word document");
    }

    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "pdf":
                    return new PDFDocument();
                case "word":
                    return new WordDocument();
                default:
                    throw new ArgumentException("Invalid document type");
            }
        }
    }
}
