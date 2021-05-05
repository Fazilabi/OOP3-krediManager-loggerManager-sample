using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruYapManager
    {

        public void Basvuru(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            
                krediManager.Hesabla();
           
            foreach (var item in loggerService)
            {
                item.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesabla();
            }
        }
    }
}
