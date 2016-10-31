using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Data.DataAccess
{
    public class EFData
    {
        private CostumeDBEntities db = new CostumeDBEntities();

        #region Get Functions
        public List<Costume> GetCostumes()
        {
            return db.Costumes.ToList();
        }

        public List<CostumeType> GetCostumeTypes()
        {
            return db.CostumeTypes.ToList();
        }
        #endregion

        #region Insert Functions
        public bool InsertCostume(Costume costume)
        {
            db.Costumes.Add(costume);

            return db.SaveChanges() > 0;
        }

        public bool InsertCostumeType(CostumeType costumeType)
        {
            db.CostumeTypes.Add(costumeType);

            return db.SaveChanges() > 0;
        }
        #endregion

        #region Change Functions
        public bool ChangeCostumeType(CostumeType costumeType, EntityState state)
        {
            var entry = db.Entry<CostumeType>(costumeType);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public bool ChangeCostume(Costume costume, EntityState state)
        {
            var entry = db.Entry<Costume>(costume);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public bool ChangeCompletedState(Costume costume, bool newValue)
        {
            costume.Completed = newValue;
            var entry = db.Entry<Costume>(costume);

            entry.State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        #endregion

        #region Get Search Functions
        public List<Costume> GetAllCostumes()
        {
            var costumes = db.Costumes.ToList();

            return costumes;
        }

        public List<Costume> GetAllCompletedCostumes()
        {
            var costumes = db.Costumes.Where(c => c.Complete == true);

            return costumes.ToList();
        }

        public List<Costume> GetAllIncompletedCostumes()
        {
            var costumes = db.Costumes.Where(c => c.Complete == false);

            return costumes.ToList();
        }
        #endregion
    }
}
