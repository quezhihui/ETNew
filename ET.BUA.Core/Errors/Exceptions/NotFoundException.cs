using System;
using System.Collections.Generic;
using ET.Core.Errors.Internal;

namespace ET.Core.Errors.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message = Defaults.NotFoundException.Title, Exception exception = null, Dictionary < string, IEnumerable<string>> messages = null )
            : base(message, exception, messages)
        {}
    }
}
