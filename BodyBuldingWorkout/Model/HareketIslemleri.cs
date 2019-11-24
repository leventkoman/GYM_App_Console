using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class HareketIslemleri : BaseClass, IOperations<HareketGrubu>

    {
        public HareketGrubu Add(HareketGrubu model)
        {
            if (model!=null)
            {
                try
                {                   
                    _tmpHarGrup = new HareketGrubu();
                    _tmpHarGrup.HareketAdi = model.HareketAdi;
                    db.HareketGrubu.Add(_tmpHarGrup);
                    db.SaveChanges();
                    Console.WriteLine(_tmpHarGrup.HareketAdi + "  Hareket grubuna başarı ile eklendi.");
                }
                catch 
                {

                    return null;
                }
            }
            return null;
        }

        public bool DeleteIt(HareketGrubu model)
        {
            if (model!=null)
            {
                try
                {
                    _silinecekhareket = db.HareketGrubu.Find(model.Id);
                    db.HareketGrubu.Remove(_silinecekhareket);
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

        public IList<HareketGrubu> Listall()
        {
            return db.HareketGrubu.ToList();
        }

        public IList<HareketGrubu> ListAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
