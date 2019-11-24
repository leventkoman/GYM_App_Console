using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class AntremanIslemleri : BaseClass, IOperations<Antreman>
    {
        public Antreman Add(Antreman model)
        {
            if (model!=null)
            {
                try
                {
                    _tmpAntreman = new Antreman();
                    _tmpAntreman.SporcuId = model.SporcuId;
                    _tmpAntreman.HarAltGrupId = model.HarAltGrupId;
                    db.Antreman.Add(_tmpAntreman);
                    db.SaveChanges();
                    Console.WriteLine(_tmpSporcu.Adi+_tmpSporcu.Soyadi+" İsimli Sporcuya Antreman başarılı bir şekilde eklendi.");
                }
                catch 
                {

                    return null;
                }

            }
            return null;
        }

        public bool DeleteIt(Antreman model)
        {
            if (model!=null)
            {
                try
                {
                    _silinecekantreman = db.Antreman.Find(model.Id);
                    db.Antreman.Remove(_silinecekantreman);
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

        public IList<Antreman> Listall()
        {
            return db.Antreman.ToList(); 
        }

        public IList<Antreman> ListAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
