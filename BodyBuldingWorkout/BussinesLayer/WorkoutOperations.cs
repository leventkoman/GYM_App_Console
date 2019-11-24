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
    public class WorkoutOperations : BaseClass
    {
        public void AnremanIslemleriList()
        {
            _hai = new HareketAltGrupIslemleri();
            _hi = new HareketIslemleri();
            _ai = new AntremanIslemleri();
            _si = new SporcuIslemleri();

            if (_ai.Listall().Count == 0)
            {
                Console.WriteLine("Sisteme kayıtlı antreman bulunmamaktadır.");
            }
            else
            {

                if (_si.Listall().Count == 0)
                {
                    Console.WriteLine("Listede sporcu  bulunmamaktadır.");
                }
                else
                {
                    var antrenmanliste = db.Antreman.ToList();
                    foreach (var item in antrenmanliste)
                    {

                        Console.WriteLine(item.Sporcu.Adi + " " + item.Sporcu.Soyadi + " kişisinin" + item.HareketAltGrubu.HarAltGrupAdi + " hareketi");

                    }

                }


            }
        }
        public void AnremanIslemleriAdd()
        {
            antreman = new Antreman();
            sporcu = new Sporcu();
            haraltgrubu = new HareketAltGrubu();
            _ai = new AntremanIslemleri();
            _hi = new HareketIslemleri();
            _hai = new HareketAltGrupIslemleri();
            _si = new SporcuIslemleri();
            Console.WriteLine("Antreman eklemek istediğiniz sporcunun ID sini giriniz : ");

            var liste = _si.Listall();
            foreach (var item in liste)
            {
                Console.WriteLine("ID: " + item.Id + " Adı: " + item.Adi + "  Soyadı: " + item.Soyadi);
                int deger = _si.Listall().Count();


                Console.WriteLine(" Eklemek istediğiniz hareket bölgesinin ID sini seçiniz: ");
                var hareket = _hi.Listall();
                foreach (var _har in hareket)
                {

                    Console.WriteLine("ID: " + _har.Id + " Hareket Bölgesinin Adı : " + _har.HareketAdi);

                    var _lis = (from x in db.Antreman where x.HareketAltGrubu.HareketGrupId == _har.Id select x).ToList();
                    foreach (var _althark in _lis)
                    {
                        Console.WriteLine(" ID : " + _althark.Id + " Hareketin Adı: " + _althark.HareketAltGrubu.HarAltGrupAdi);
                    }
                }
                Console.WriteLine("*********************************************************************");
            }
            var AthleteId = Console.ReadLine();
            int _sporcuid = Convert.ToInt32(AthleteId);
            antreman.SporcuId = _sporcuid;
            var ActionId = Console.ReadLine();
            int _hareketid = Convert.ToInt32(ActionId);
            var SubActionId = Console.ReadLine();
            int _althareketid = Convert.ToInt32(SubActionId);
            antreman.HarAltGrupId = _althareketid;
            _ai.Add(antreman);

        }
        public void AnremanIslemleriRemove()
        {
            Antreman _silinecek;
            foreach (var item in db.Antreman.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Sporcu Adı ve Soyadı " + item.Sporcu.Adi + " " + item.Sporcu.Soyadi);
                Console.WriteLine("Hareket Adı : " + item.HareketAltGrubu.HarAltGrupAdi);
            }
            Console.WriteLine("Silmek istediğiniz Antremanın ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.Antreman.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }
        }
        public string IsEmpty(int? antremanId)
        {
            if (antremanId != null)
            {
                var _silinecek = db.Antreman.Find(antremanId);
                db.Antreman.Remove(_silinecek);
                db.SaveChanges();
                return " Silme işlemi başarılı";
            }
            return " Geçerli bir tuş giriniz.";
        }
    }
}