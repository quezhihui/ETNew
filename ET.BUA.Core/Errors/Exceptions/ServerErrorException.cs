using System;
using System.Collections.Generic;
using ET.Core.Errors.Internal;

namespace ET.Core.Errors.Exceptions
{
    public class ServerErrorException : BaseException
    {
        public ServerErrorException(string message = Defaults.ServerErrorException.Title, Exception exception = null, Dictionary < string, IEnumerable<string>> messages = null )
            : base(message, exception, messages)
        {}
    }
}
