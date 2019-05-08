using System;
using System.Collections.Generic;
using System.Text;

namespace Cosino
{
    public class FraudException : Exception
    {
        public FraudException()
         : base() { }
        public FraudException(string message)
        : base(message) { }


    }
}
