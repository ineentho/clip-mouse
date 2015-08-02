using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClipMouse.WinAPI
{
    class InvokeException : Exception
    {
        public InvokeException(string method)
            : base(String.Format("Error Calling Invoke.{0}", method)) { }
    }
}
