using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            

            KonutKrediManager konutKrediManager = new KonutKrediManager();
         

            BasvuruYapManager basvuruYapManager = new BasvuruYapManager();
            //basvuruYapManager.Basvuru(konutKrediManager);

            List<IKrediManager> krediManagers = new List<IKrediManager>() {tasitKrediManager, konutKrediManager};
            List<ILoggerService> loggerServices = new List<ILoggerService>() { new EmailLoggerService(), new DatabaseLoggerService() };

            //basvuruYapManager.KrediOnBilgilendirmesiYap(krediManagers);

            basvuruYapManager.Basvuru(tasitKrediManager, loggerServices);




        }
    }
}
