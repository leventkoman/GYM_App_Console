using BodyBuldingWorkout.BussinesLayer;
using BodyBuldingWorkout.Repository;
using BodyBuldingWorkout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout
{
      class Program:BaseClass
    {
        public static void Main(string[] args)
        {
            Menu();
        }
       public static void Menu()
        {
            while (true)
            {
                SelectOperations selopr = new SelectOperations();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Sporcu işlemleri için 1 i tuşlayınız.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Hareket grubu işlemleri için 2 yi tuşlayınız");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Hareket Alt Grubu işlemleri için 3 ü tuşlayınız.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Ölçüm Tipi işlemleri için 4 ü tuşlayınız");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Ölçüm işlemleri için 5 i tuşlayınız.");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Antreman işlemleri için 6 yı tuşlayınız.");
                Console.WriteLine("-------------------------------------");
                string _tus = Console.ReadLine();

                if (_tus == "1" || _tus == "2" || _tus == "3" || _tus == "4" || _tus == "5" || _tus == "6")
                {

                    int tus = Convert.ToInt16(_tus);

                    if (tus == 1)
                    {                       
                        selopr.SelectSporcu();                        
                    }
                    else if (tus == 2)
                    {
                        selopr.SelectHareketler();                        
                   }
                    else if (tus == 3)
                    {
                        selopr.SelectHareketAlt();
                    }
                    else if (tus == 4)
                    {
                        selopr.SelectOlcumTipi();
                    }
                    else if (tus == 5)
                    {
                        selopr.SelectOlcum();
                    }
                    else if (tus == 6)
                    {
                        selopr.SelectAntreman();
                    }
                   
                    else if (tus != 1 || tus != 2 || tus != 3 || tus != 4 || tus != 5 || tus != 6 )
                    {
                        Console.WriteLine("Geçerli bir işlem seçmediniz...");
                    }
                }
            }
        }
    }
}
