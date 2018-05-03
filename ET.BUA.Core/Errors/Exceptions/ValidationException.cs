using System;
using System.Collections.Generic;
using ET.Core.Errors.Internal;

namespace ET.Core.Errors.Exceptions
{
    public class ValidationException : BaseException
    {
        public ValidationException(string message = Defaults.ValidationException.Title, Exception exception = null, Dictionary<string, IEnumerable<string>> messages = null)
            : base(message, exception, messages)
        { }
    }
}
