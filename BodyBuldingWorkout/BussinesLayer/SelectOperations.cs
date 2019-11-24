using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.BussinesLayer
{
    public class SelectOperations : BaseClass
    {
       
        public void SelectSporcu()
        {
            athleteopr = new AthleteOperations();
            Console.WriteLine("Sporcu eklemek için için 1'e");
            Console.WriteLine("--------------------");
            Console.WriteLine("Sporcu silmek için 2'e");
            Console.WriteLine("--------------------");
            Console.WriteLine("Sporcu listelemek için 3 e basınız");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Sporcuları alfabeye sıralamak için 4 e basınız");
            Console.WriteLine("-------------------------------------------");
            string _tus = Console.ReadLine();

            if (_tus == "1" || _tus == "2" || _tus == "3" || _tus == "4")
            {
                int tus = Convert.ToInt16(_tus);

                if (tus == 1)
                {
                    
                    athleteopr.SporcuIslemleriAdd();

                }
                else if (tus == 2)
                {
                    athleteopr.SporcuIslemleriRemove();
                }
                else if (tus == 3)
                {

                    athleteopr.SporcuIslemleriList();
                }
                else if (tus == 4)
                {
                    athleteopr.SporcuIslemleriAlphabetList();
                }
            }
        }
        public void SelectAntreman()
        {
            workoutopr = new WorkoutOperations();
            Console.WriteLine("Antreman eklemek için 1 e basınız ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Antreman silmek için 2' ye");
            Console.WriteLine("---------------------");
            Console.WriteLine("Antremanları listelemek için 3 e basınız");
            Console.WriteLine("----------------------------------------");
            string _tus = Console.ReadLine();
            if (_tus == "1" || _tus == "2" || _tus == "3")
            {
                int tus = Convert.ToInt16(_tus);
                if (tus == 1)
                {
                    workoutopr.AnremanIslemleriAdd();
                }
                else if (tus == 2)
                {
                    workoutopr.AnremanIslemleriRemove();
                }
                else if (tus == 3)
                {
                    workoutopr.AnremanIslemleriList();
                }
            }
        }
        public void SelectOlcum()
        {
            measureopr = new MeasurementOperations();
            Console.WriteLine("Sporcuya Ölçüm eklemek için için 1'e");
            Console.WriteLine("--------------------");
            Console.WriteLine("Sporcunun ölçümlerini silmek için 2'e");
            Console.WriteLine("--------------------");
            Console.WriteLine("Yapılan Ölçümleri listelemek için 3 e basınız");
            Console.WriteLine("-------------------------------------------");
            string _tus = Console.ReadLine();

            if (_tus == "1" || _tus == "2" || _tus == "3")
            {
                int tus = Convert.ToInt16(_tus);

                if (tus == 1)
                {

                    measureopr.OlcumIslemleriAdd();

                }
                else if (tus == 2)
                {
                    measureopr.OlcumIslemleriRemove();
                }
                else if (tus == 3)
                {
                    measureopr.OlcumIslemleriList();
                }
            }
        }
        public void SelectHareketler()
        {
            actionopr = new ActionOprerations();
            Console.WriteLine("Hareket eklemek için 1 e basınız ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Hareket silmek için 2' ye");
            Console.WriteLine("---------------------");
            Console.WriteLine("Hareketleri listelemek için 3e basınız");
            Console.WriteLine("---------------------");
            string _tus = Console.ReadLine();
            if (_tus == "1" || _tus == "2" || _tus == "3")
            {
                int tus = Convert.ToInt16(_tus);
                if (tus == 1)
                {
                    actionopr.HareketIslemleriAdd();
                }
                else if (tus == 2)
                {
                    actionopr.HareketIslemleriRemove();
                }
                else if (tus == 3)
                {
                    actionopr.HareketIslemleriList();
                }
            }
        }
        public void SelectHareketAlt()
        {
            actionsubopr = new ActionSubOperations();
            Console.WriteLine("Alt Hareket Grubu eklemek için 1 e basınız ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Alt Hareket Grubu silmek için 2' ye");
            Console.WriteLine("---------------------");
            Console.WriteLine("Alt Hareket Grubunu Listelemek için 3 e basınız.");
            Console.WriteLine("-------------------------------------------");
            string _tus = Console.ReadLine();
            if (_tus == "1" || _tus == "2" || _tus == "3")
            {
                int tus = Convert.ToInt16(_tus);
                if (tus == 1)
                {
                    actionsubopr.AltHareketIslemleriAdd();
                }
                else if (tus == 2)
                {
                    actionsubopr.AltHareketIslemleriDelete();
                }
                else if (tus == 3)
                {
                    actionsubopr.AltHareketIslemleriList();
                }
            }
        }
        public void SelectOlcumTipi()
        {
            measuretypeopr = new MeasurementTypeOperations();
            Console.WriteLine("Ölçüm Tipi eklemek için 1 e basınız ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Ölçüm Tipi silmek için 2' ye");
            Console.WriteLine("---------------------");
            Console.WriteLine("Ölçüm Tiplerini listelemek için 3 e basınız");
            Console.WriteLine("-------------------------------------------");
            string _tus = Console.ReadLine();
            if (_tus == "1" || _tus == "2" || _tus == "3")
            {
                int tus = Convert.ToInt16(_tus);
                if (tus == 1)
                {
                    measuretypeopr.OlcumTipiIslemleriAdd();
                }
                else if (tus == 2)
                {
                    measuretypeopr.OlcumTipiIslemleriRemove();
                }
                else if (tus == 3)
                {
                    measuretypeopr.OlcumTipiIslemleriList();
                }
            }
        }
    }
}
