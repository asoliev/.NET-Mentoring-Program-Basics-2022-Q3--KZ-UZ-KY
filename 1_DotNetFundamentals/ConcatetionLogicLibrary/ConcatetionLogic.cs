using System;

namespace ConcatetionLogicLibrary
{
    public class ConcatetionLogic
    {
        public string Output(string username)
        {
            return $"{DateTime.Now} Hello, {username}";
        }
    }
}
