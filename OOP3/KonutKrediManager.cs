using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesabla()
        {
            Console.WriteLine("konut kredi hesablandi");
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
