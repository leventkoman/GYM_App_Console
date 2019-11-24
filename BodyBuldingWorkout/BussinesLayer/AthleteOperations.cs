using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuldingWorkout.Model;
using BodyBuldingWorkout.DAL;
using System.Collections;

namespace BodyBuldingWorkout.BussinesLayer
{
    public class AthleteOperations : BaseClass
    {
        public string _sporcuad;
        public string _sporcusoyad;
        public string _yas;
        public int _sira = 1;
        private AthleteFindModel afmodel;
        private List<AthleteFindModel> afmodellist;

        public void SporcuIslemleriList()
        {

            _si = new SporcuIslemleri();
            if (_si.Listall().Count == 0)
            {
                Console.WriteLine("Listede sporcu yok");
            }
            else
            {
                var liste = _si.Listall();
                foreach (var item in liste)
                {
                    Console.WriteLine("Sporcunun Adi : " + item.Adi + "  Soyadı : " + item.Soyadi + "  Yaşı : " + item.Yasi);

                }
            }
        }

        public void SporcuIslemleriAdd()
        {
            _si = new SporcuIslemleri();
            sporcu = new Sporcu();
            Console.WriteLine("Sporcunun Adını giriniz.");
            sporcu.Adi = Console.ReadLine();
            Console.WriteLine("Sporcunun Soyadını giriniz.");
            sporcu.Soyadi = Console.ReadLine();
            Console.WriteLine("Sporcunun Yaşını giriniz.");
            sporcu.Yasi = Console.ReadLine();
            _si.Add(sporcu);


        }

        public void SporcuIslemleriRemove()
        {

            Sporcu _silinecek;
            foreach (var item in db.Sporcu.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Adı ve Soyadı : " + item.Adi + " " + item.Soyadi);
            }
            Console.WriteLine("Silmek istediğiniz Sporcunun ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.Sporcu.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }

        }

        public string IsEmpty(int? sporcuId)
        {
            if (sporcuId != null)
            {
                var _silinecek = db.Sporcu.Find(sporcuId);
                db.Sporcu.Remove(_silinecek);
                db.SaveChanges();
                return " Silme işlemi başarılı";

            }
            return " Geçerli bir tuş giriniz.";
        }

        public void SporcuIslemleriAlphabetList()
        {
            Antreman _listelenecek;
            _hai = new HareketAltGrupIslemleri();
            _hi = new HareketIslemleri();
            _ai = new AntremanIslemleri();
            _si = new SporcuIslemleri();
            SortedList _sorlist = new SortedList();
            _si = new SporcuIslemleri();
            if (_si.ListAlphabet().Count == 0)
            {
                Console.WriteLine("Listede sporcu yok");
            }
            else
            {

                var liste = _si.ListAlphabet();
                afmodellist = new List<AthleteFindModel>();
                foreach (var item in liste)
                {
                    Console.WriteLine("Sporcunun Sırası " + _sira + " Sporcunun Adi : " + item.Adi + "  Soyadı : " + item.Soyadi + "  Yaşı : " + item.Yasi);
                    afmodel = new AthleteFindModel();
                    afmodel.Id = item.Id;
                    afmodel.Sira = _sira;
                    afmodellist.Add(afmodel);

                    _sira++;

                }
                Console.WriteLine("Antremanı görüntülemek istediğiniz sporcunun sırasını giriniz.");
                var tus = Console.ReadLine();
                int sira = Convert.ToInt32(tus);

                var arananSporcu  = afmodel.FindIt(afmodellist, sira);
                foreach (var item in arananSporcu.Antreman)
                {
                    Console.WriteLine(item.Sporcu.Adi+" "+item.Sporcu.Soyadi+" kişisinin antrenman listesinde "+item.HareketAltGrubu.HarAltGrupAdi+" hareketi bulunmaktadır.");
                }
            }
        }

        public Sporcu SporcuBul()
        {

            return null;
        }
    }
}
