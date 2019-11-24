using BodyBuldingWorkout.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuldingWorkout.DAL;

namespace BodyBuldingWorkout.BussinesLayer
{
  public class CompareOperations:BaseClass
    {
        public bool CompareAction(string _actionName)
        {

            var _allActions = (from x in db.HareketGrubu select x.HareketAdi).ToList();
            foreach (var item in _allActions)
            {

                if (item == _actionName)
                {
                    return true;
                }

            }

            return false;

        }

       
    }
}
