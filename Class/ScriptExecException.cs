using System;

namespace ScriptExec
{
    public class ScriptExecException : ApplicationException
    {
        public ScriptExecException(string message)
        {
            throw new ApplicationException(message);
        }

        public ScriptExecException(string message, Exception exception)
        {
            throw new ApplicationException(message, exception);
        }
    }
}