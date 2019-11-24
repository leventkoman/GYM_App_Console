using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class SporcuIslemleri : BaseClass, IOperations<Sporcu>
    {
        public Sporcu Add(Sporcu model)
        {
            if (model!=null)
            {
                try
                {
                    _tmpSporcu = new Sporcu();
                    _tmpSporcu.Adi = model.Adi;
                    _tmpSporcu.Soyadi = model.Soyadi;
                    _tmpSporcu.Yasi = model.Yasi;

                    db.Sporcu.Add(_tmpSporcu);
                    db.SaveChanges();                    
                    Console.WriteLine(_tmpSporcu.Adi + " " + _tmpSporcu.Soyadi + " Başarı ile eklendi");
                }
                catch 
                {

                    return null;
                }
            }
            return null;
        }

        public bool DeleteIt(Sporcu model)
        {
            if (model!=null)
            {
                try
                {
                    _silineceksporcu = db.Sporcu.Find(model.Id);
                    db.Sporcu.Remove(_silineceksporcu);
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

        public IList<Sporcu> Listall()
        {
            return db.Sporcu.ToList();
        }

        public IList<Sporcu> ListAlphabet()
        {
            return  db.Sporcu.OrderBy(sira=>sira.Adi).ToList();
        }
    }
}
