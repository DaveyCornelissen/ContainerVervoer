using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerTransport
{
    public class ExceptionHandler : Exception
    {

        /// <summary>
        /// Returns a normal message
        /// </summary>
        /// <param name="message"></param>
        public ExceptionHandler(string message)
            : base(message) { }

        /// <summary>
        /// Returns a normal message with params variables
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public ExceptionHandler(string format, params object[] args)
            : base(string.Format(format, args)) { }
    }
}
