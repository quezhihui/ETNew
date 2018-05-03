using System;
using System.Collections.Generic;
using ET.Core.Errors.Internal;

namespace ET.Core.Errors.Exceptions
{
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message = Defaults.UnauthorizedException.Title, Exception exception = null, Dictionary<string, IEnumerable<string>> messages = null)
            : base(message, exception, messages)
        { }
        public UnauthorizedException(string message) : base(Defaults.UnauthorizedException.Title, null, null)
        {
            base.AddMessage(message);

        }
    }
}
