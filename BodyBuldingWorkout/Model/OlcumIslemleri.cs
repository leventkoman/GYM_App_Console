using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class OlcumIslemleri : BaseClass, IOperations<Olcum>
    {
        public Olcum Add(Olcum model)
        {
            if (model!=null)
            {
                try
                {
                    _tmpOlcum = new Olcum();
                   // _tmpOlcum.Id = model.Id;
                    _tmpOlcum.SporcuId = model.SporcuId;
                    _tmpOlcum.OlcumTipiId = model.OlcumTipiId;
                    _tmpOlcum.OlcumDegeri=model.OlcumDegeri;
                    _tmpOlcum.OlcumTarihi = model.OlcumTarihi;

                    db.Olcum.Add(_tmpOlcum);
                    db.SaveChanges();

                    Console.WriteLine("ID si : "+_tmpOlcum.SporcuId + " olan sporcunun ölçüm bilgileri aşağıdaki gibidir." );
                    Console.WriteLine(_tmpOlcum.OlcumTipiId);
                    Console.WriteLine(_tmpOlcum.OlcumDegeri);
                    Console.WriteLine(_tmpOlcum.OlcumTarihi);
                    
                }
                catch 
                {

                    return null;
                }
            }
            return null;
        }

        public bool DeleteIt(Olcum model)
        {
            if (model!=null)
            {
                try
                {
                    _silinecekolcum = db.Olcum.Find(model.Id);
                    db.Olcum.Remove(_silinecekolcum);
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

        public IList<Olcum> Listall()
        {
            return db.Olcum.ToList();
        }

        public IList<Olcum> ListAlphabet()
        {
            throw new NotImplementedException();
        }
    }
}
