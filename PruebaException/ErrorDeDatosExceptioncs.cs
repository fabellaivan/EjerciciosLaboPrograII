
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PruebaException
{
    internal class ErrorDeDatosExceptioncs : Exception
    {
        public ErrorDeDatosExceptioncs()
        {
        }

        public ErrorDeDatosExceptioncs(string? message) : base(message)
        {
        }

        public ErrorDeDatosExceptioncs(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public override string StackTrace
        {
            get
            {
               return  base.StackTrace + " ";
            }
        }
    }
}
