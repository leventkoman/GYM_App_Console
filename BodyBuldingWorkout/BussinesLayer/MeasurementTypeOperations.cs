using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Model;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.BussinesLayer
{
    public class MeasurementTypeOperations : BaseClass
    {
        public void OlcumTipiIslemleriList()
        {
            _oti = new OlcumTipiIslemleri();

            if (_oti.Listall().Count == 0)
            {
                Console.WriteLine("Listede ölcüm tipi bulunmamaktadır.");
            }
            else
            {
                var liste = _oti.Listall();
                foreach (var item in liste)
                {
                    Console.WriteLine("Ölçüm Tipi : " + item.OlcumTipi1);
                }
            }
        }

        public void OlcumTipiIslemleriAdd()
        {
            olcumtipi = new OlcumTipi();
            Console.WriteLine("Ölçüm tipi giriniz.");
            olcumtipi.OlcumTipi1 = Console.ReadLine();
            _oti.Add(olcumtipi);

        }

        public void OlcumTipiIslemleriRemove()
        {
            OlcumTipi _silinecek;
            foreach (var item in db.OlcumTipi.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Ölçüm Tipi " + item.OlcumTipi1);
            }
            Console.WriteLine("Silmek istediğiniz Ölçüm tipinin ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.OlcumTipi.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }
        }

        public string IsEmpty(int? olcumId)
        {
            if (olcumId != null)
            {
                var _silinecek = db.OlcumTipi.Find(olcumId);
                db.OlcumTipi.Remove(_silinecek);
                db.SaveChanges();
                return " Silme işlemi başarılı";

            }
            return " Geçerli bir tuş giriniz.";
        }
    }

}
