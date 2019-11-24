using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class HareketAltGrupIslemleri : BaseClass, IOperations<HareketAltGrubu>
    {
        public HareketAltGrubu Add(HareketAltGrubu model)

        {
            if (model!=null)
            {
                try
                {
                    _tmpHarAltGrup = new HareketAltGrubu();
                    _tmpHarAltGrup.HareketGrupId = model.HareketGrupId;
                    _tmpHarAltGrup.HarAltGrupAdi = model.HarAltGrupAdi;
                    db.HareketAltGrubu.Add(_tmpHarAltGrup);
                    db.SaveChanges();

                    Console.WriteLine(_tmpHarAltGrup.HarAltGrupAdi + " İsimli Hareket Başarı ile eklendi.");
                    
                }
                catch 
                {

                    return null;
                }
            }
            return null;
        }

        public bool DeleteIt(HareketAltGrubu model)
        {
            if (model!=null)
            {
                try
                {
                    _silinecekalthareket = db.HareketAltGrubu.Find(model.Id);
                    db.HareketAltGrubu.Remove(_silinecekalthareket);
                    db.SaveChanges();
                    return true;
                }
                catch 
                {

                    return false; 
                }
            }
            return false;
        }

        public IList<HareketAltGrubu> Listall()
        {
            return db.HareketAltGrubu.ToList();
        }

        public IList<HareketAltGrubu> ListAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
