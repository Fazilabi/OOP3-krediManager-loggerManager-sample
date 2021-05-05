using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesabla()
        {
            Console.WriteLine("tasit kredi hesablandi");
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
