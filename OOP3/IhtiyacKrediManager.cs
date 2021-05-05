using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesabla()
        {
            Console.WriteLine("ihtiyac kredi hesablandi");
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
