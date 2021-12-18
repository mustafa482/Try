using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
   public class OperationMyException:Exception
    {
        public string OperationName { get; set; }

        public OperationMyException(string message) : base(message)
        {

        }
        public OperationMyException(string message,Exception innerException) : base(message,innerException)
        {

        }
        public OperationMyException(string message, Exception innerException,string operation):this(message, innerException)
        {
            OperationName = operation;
        }

    }
}
