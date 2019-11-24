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
    public class MeasurementOperations : BaseClass
    {
        public void OlcumIslemleriList()
        {

            _si = new SporcuIslemleri();
            _oti = new OlcumTipiIslemleri();
            _oi = new OlcumIslemleri();

            if (_si.Listall().Count == 0)
            {
                Console.WriteLine("Sisteme kayıtlı Sporcu bulunmamaktadır. ");
            }
            else if (_oti.Listall().Count == 0)
            {
                Console.WriteLine("Sisteme kayıtlı ölçüm tipi bulunmamaktadır.");
            }
            else
            {
                if (_si.Listall().Count == 0)
                {
                    Console.WriteLine("Sisteme kayıtlı ölçüm bulunamadı");
                }
                else
                {
                    var liste = _si.Listall();
                    foreach (var item in liste)
                    {
                        Console.WriteLine("-->" + item.Adi + " " + item.Soyadi + "  Sporcusuna ait");
                        var olcdegeri = (from _olcumdeg in db.Olcum where _olcumdeg.SporcuId == item.Id select _olcumdeg).ToList();
                        foreach (var _olde in olcdegeri)
                        {
                            Console.WriteLine("Ölçüm tip--->  " + _olde.OlcumTipi.OlcumTipi1);
                            Console.WriteLine("Ölçüm değeri ---> " + _olde.OlcumDegeri + " ---- " + " Ölçüm Tarihi ---> " + _olde.OlcumTarihi);
                            Console.WriteLine("*****************************************************************");
                        }
                    }
                }
            }
        }

        public void OlcumIslemleriAdd()
        {
            sporcu = new Sporcu();
            olcumtipi = new OlcumTipi();
            olcum = new Olcum();
            _si = new SporcuIslemleri();
            _oti = new OlcumTipiIslemleri();
            _oi = new OlcumIslemleri();
            Console.WriteLine("Ölçüm yapmak istediğiniz sporcunun Id sini aşağıdan seçiniz");
            var liste = _si.Listall();
            foreach (var item in liste)
            {
                Console.WriteLine("ID: " + item.Id + " Adı: " + item.Adi + " Soyadı: " + item.Soyadi);

                var tip = _oti.Listall(); //(from x in db.OlcumTipi where x.Id == item.Id select x).ToList();
                foreach (var y in tip)
                {
                    Console.WriteLine("Eklemek istediğiniz Ölçüm Bölgesi Id sini aşağıdan seçiniz");
                    Console.WriteLine("ID " + y.Id + " Ölçüm İsmi: " + y.OlcumTipi1);

                }
                Console.WriteLine("*****************************************************************************************");
            }
            var SporcuId = Console.ReadLine();
            int _sporcuid = Convert.ToInt16(SporcuId);
            olcum.SporcuId = _sporcuid;
            var OlcumTipId = Console.ReadLine();
            int _olcumtipid = Convert.ToInt16(OlcumTipId);
            olcum.OlcumTipiId = _olcumtipid;
            Console.WriteLine("Ölçüm değeri giriniz : ");
            var OlcumDegeri = Console.ReadLine();
            int _olcumdegeri = Convert.ToInt16(OlcumDegeri);
            olcum.OlcumDegeri = _olcumdegeri;
            olcum.OlcumTarihi = DateTime.Now;
            _oi.Add(olcum);



        }

        public void OlcumIslemleriRemove()
        {
            Olcum _silinecek;
            foreach (var item in db.Olcum.ToList())
            {
                Console.WriteLine("ID : " + item.Id + " Sporcu Adı ve Soyadı " + item.Sporcu.Adi + " " + item.Sporcu.Soyadi);
                Console.WriteLine("Ölçüm Tipi : " + item.OlcumTipi.OlcumTipi1 + " Ölçüm Değeri : " + item.OlcumDegeri + " Ölçüm Tarihi: " + item.OlcumTarihi);
            }
            Console.WriteLine("Silmek istediğiniz Ölçümün ID sini giriniz.");
            var tus = Console.ReadLine();
            int _tus = Convert.ToInt32(tus);
            _silinecek = db.Olcum.Find(_tus);
            if (_silinecek != null)
            {
                Console.WriteLine(IsEmpty(_silinecek.Id));
            }
            else
            {
                Console.WriteLine("Bu ID yok");
            }
        }

        public string IsEmpty(int? olcumtId)
        {
            if (olcumtId != null)
            {
                var _silinecek = db.Olcum.Find(olcumtId);
                db.Olcum.Remove(_silinecek);
                db.SaveChanges();
                return " Silme işlemi başarılı";
            }
            return " Geçerli bir tuş giriniz.";
        }

    }
}


