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
    public class ActionSubOperations : BaseClass
    {
        public void AltHareketIslemleriList()
        {
            _hi = new HareketIslemleri();
            _hai = new HareketAltGrupIslemleri();

            if (_hai.Listall().Count == 0)
            {
                Console.WriteLine("Listede Alt hareket isimleri bulunmamaktadır.");
            }
            else
            {
                if (_hi.Listall().Count == 0)
                {
                    Console.WriteLine("Listede hareket isimleri bulunmamaktadır.");
                }
                else
                {
                    var liste = _hi.Listall();
                    foreach (var item in liste)
                    {
                        Console.WriteLine("Hareket Grubunun İSmi : " + item.HareketAdi);
                        if (item.HareketAltGrubu.Count != 0)
                        {
                            var althargrup = (from ahg in db.HareketAltGrubu where ahg.HareketGrupId == item.Id select ahg).ToList();
                            foreach (var _althargr in althargrup)
                            {
                                Console.WriteLine("Alt Hareket Grubun adı : " + _althargr.HarAltGrupAdi);
                            }
                        }
                        else if (item.HareketAltGrubu.Count == 0)
                        {
                            Console.WriteLine(item.HareketAdi + " Grubuna ait hareket ismi eklenmemiştir.");
                        }
                    }
                }
            }
        }
        public void AltHareketIslemleriAdd()
        {
            hareketgrubu = new HareketGrubu();
            haraltgrubu = new HareketAltGrubu();
            Console.WriteLine("Hareket İsmini giriniz.");
            haraltgrubu.HarAltGrupAdi = Console.ReadLine();
            Console.WriteLine("Hareketin Grubunun ID sini aşağıdan seçerek giriniz.");
            var liste = _hi.Listall();
            foreach (var item in liste)
            {
                Console.WriteLine("ID: " + item.Id + " Hareketin Grubu: " + item.HareketAdi);
                Console.WriteLine("**************************************");
            }
            var harid = Console.ReadLine();
            int _harid = Convert.ToInt16(harid);
            haraltgrubu.HareketGrupId = _harid;
            _hai.Add(haraltgrubu);
        }
        public void AltHareketIslemleriDelete()
        {
            HareketAltGrubu _silinecek;
            foreach (var item in db.HareketAltGrubu.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Hareketin İsmi Giriniz " + item.HarAltGrupAdi);
            }
            Console.WriteLine("Silmek istediğiniz Hareketin ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.HareketAltGrubu.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }
        }
        public string IsEmpty(int? hareketaltId)
        {
            if (hareketaltId!=null)
            {                                
                _silinecekalthareket = db.HareketAltGrubu.Find(hareketaltId);
                db.HareketAltGrubu.Remove(_silinecekalthareket);
                db.SaveChanges();
                return "Silme işlemi başarılı !!";              
            }
            return "Geçerli bir tuş basınız";
        }
    }
}
