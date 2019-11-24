using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Model
{
    public class AthleteFindModel:BaseClass
    {
        public int Id { get; set; }

        public int Sira { get; set; }

        public Sporcu FindIt(List<AthleteFindModel> liste, int sira)
        {
            //var sporculistesi = db.Sporcu.ToList();
            AthleteFindModel athlete = new AthleteFindModel();
            foreach (var item in liste)
            {
                if (item.Sira==sira)
                {
                    athlete.Id = item.Id;
                }
            }







            return db.Sporcu.Find(athlete.Id); ;
        }

    }
}
