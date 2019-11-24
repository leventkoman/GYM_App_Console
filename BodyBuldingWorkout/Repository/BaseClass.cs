using BodyBuldingWorkout.BussinesLayer;
using BodyBuldingWorkout.DAL;
using BodyBuldingWorkout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuldingWorkout.Repository
{
   public class BaseClass
    {
        public WorkOutDBEntities db = new WorkOutDBEntities();
        public Sporcu _tmpSporcu;
        public Antreman _tmpAntreman;
        public HareketGrubu _tmpHarGrup;
        public HareketAltGrubu _tmpHarAltGrup;
        public Olcum _tmpOlcum;
        public OlcumTipi _tmpOlcumTipi;
        public Sporcu _silineceksporcu;
        public Antreman _silinecekantreman;
        public HareketGrubu _silinecekhareket;
        public HareketAltGrubu _silinecekalthareket;
        public Olcum _silinecekolcum;
        public OlcumTipi _silinecekolcumtipi;       
        public SporcuIslemleri _si ;
        public HareketIslemleri _hi;
        public HareketAltGrupIslemleri _hai;
        public OlcumTipiIslemleri _oti;
        public OlcumIslemleri _oi;
        public AntremanIslemleri _ai;
        public Sporcu sporcu;
        public HareketGrubu hareketgrubu;
        public HareketAltGrubu haraltgrubu;
        public Antreman antreman;
        public Olcum olcum;
        public OlcumTipi olcumtipi;
        public AthleteOperations athleteopr;
        public WorkoutOperations workoutopr;
        public MeasurementOperations measureopr;
        public ActionOprerations actionopr;
        public ActionSubOperations actionsubopr;
        public MeasurementTypeOperations measuretypeopr;
        public SelectOperations selopr;
    }
}
