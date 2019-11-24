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
    public class ActionOprerations : BaseClass
    {
        public void HareketIslemleriList()
        {
            _hi = new HareketIslemleri();

            if (_hi.Listall().Count == 0)
            {
                Console.WriteLine("Listede Hareket Grubu bulunmamaktadır.");
            }
            else
            {
                var liste = _hi.Listall();
                foreach (var item in liste)
                {
                    Console.WriteLine("Hareket Grubunun  adı: " + item.HareketAdi);
                }
            }
        }
        public void HareketIslemleriAdd()
        {
            hareketgrubu = new HareketGrubu();
            Console.WriteLine("Hareket Grubu Ekleyiniz");
            hareketgrubu.HareketAdi = Console.ReadLine();
            _hi.Add(hareketgrubu);

        }
        public void HareketIslemleriRemove()
        {
            HareketGrubu _silinecek;
            foreach (var item in db.HareketGrubu.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Hareketin Bölgesi " + item.HareketAdi);
            }
            Console.WriteLine("Silmek istediğiniz Hareket bölgesinin ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.HareketGrubu.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }
        }
        public string IsEmpty(int? hareketId)
        {
            if (hareketId != null)
            {
                var _silinecek = db.HareketGrubu.Find(hareketId);
                db.HareketGrubu.Remove(_silinecek);
                db.SaveChanges();
                return " Silme işlemi başarılı";

            }
            return " Geçerli bir tuş giriniz.";
        }
    }

}
