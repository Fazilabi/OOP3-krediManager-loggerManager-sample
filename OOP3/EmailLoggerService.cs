using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EmailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Email-e loglandi");
        }
    }
}
