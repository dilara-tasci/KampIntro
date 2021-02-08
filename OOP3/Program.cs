using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Grup1
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //Grup2
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager2 = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager2 = new KonutKrediManager();
            konutKrediManager.Hesapla();

            //Grup1 ve Grup2 sorunsuz şekilde çalışır. Yani interface'ler de referans numarası tutar.
            */

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService()};
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, loggers);
           // basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
