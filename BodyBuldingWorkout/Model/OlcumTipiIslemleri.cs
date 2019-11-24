using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class OlcumTipiIslemleri : BaseClass, IOperations<OlcumTipi>
    {
        public OlcumTipi Add(OlcumTipi model)
        {
            if (model!=null)
            {
                try
                {
                    _tmpOlcumTipi = new OlcumTipi();
                    _tmpOlcumTipi.OlcumTipi1 = model.OlcumTipi1;
                    db.OlcumTipi.Add(_tmpOlcumTipi);
                    db.SaveChanges();

                    Console.WriteLine(_tmpOlcumTipi.OlcumTipi1+  " Başarı ile eklendi");
                }
                catch 
                {

                    return null;
                }
            }
            return null;
        }

        public bool DeleteIt(OlcumTipi model)
        {
            if (model!=null)
            {
                try
                {
                    _silinecekolcumtipi = db.OlcumTipi.Find(model.Id);
                    db.OlcumTipi.Remove(_silinecekolcumtipi);
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

        public IList<OlcumTipi> Listall()
        {
            return db.OlcumTipi.ToList();
        }

        public IList<OlcumTipi> ListAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
