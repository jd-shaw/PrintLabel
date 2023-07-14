using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PrintLabel.PrintDialogExceptions
{
    public class DocumentEmptyException : Exception
    {

        public override string Message { get; }


        public FixedDocument Document { get; }


        public DocumentEmptyException(string message, FixedDocument document)
        {
            Message = message;
            Document = document;
        }
    }

    public class UndefinedException : Exception
    {

        public override string Message { get; }


        public new Exception InnerException { get; }


        public DateTime ExceptionTime { get; }

        public UndefinedException(string message)
        {
            Message = message;
            ExceptionTime = DateTime.Now;
        }


        public UndefinedException(string message, Exception innerException)
        {
            Message = message;
            InnerException = innerException;
            ExceptionTime = DateTime.Now;
        }
    }
}