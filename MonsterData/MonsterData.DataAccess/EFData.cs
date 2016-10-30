using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterData.DataAccess
{
    public class EFData
    {
        private MonsterDBEntities db = new MonsterDBEntities();

        #region Get Functions
        public List<Gender> GetGenders()
        {
            return db.Genders.ToList();
        }

        public List<MonsterType> GetMonsterTypes()
        {
            return db.MonsterTypes.ToList();
        }

        public List<Title> GetTitles()
        {
            return db.Titles.ToList();
        }

        public List<Monster> GetMonsters()
        {
            return db.Monsters.ToList();
        }
        #endregion

        #region Get Search Functions
        public void GetSearchGender()
        {
            var actives = db.Genders.Where(a => a.Active);
            var inactives = db.Genders.Where(a => !a.Active);
            var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));
        }

        public void GetSearchMonsterType()
        {
            var actives = db.MonsterTypes.Where(a => a.Active);
            var inactives = db.MonsterTypes.Where(a => !a.Active);
            var ma = db.MonsterTypes.Where(m => m.TypeName.ToLower().Contains("ma"));
        }

        public void GetSearchTitle()
        {
            var actives = db.Titles.Where(a => a.Active);
            var inactives = db.Titles.Where(a => !a.Active);
            var ma = db.Titles.Where(m => m.TitleName.ToLower().Contains("ma"));
        }

        public Monster GetSearchMonster()
        {
            var actives = db.Monsters.Where(a => a.Active);
            var inactives = db.Monsters.Where(a => !a.Active);
            var ma = db.Monsters.Where(m => m.Name.ToLower().Contains("ma"));
            var last = db.Monsters.Last();

            return last;
        }
        #endregion

        #region Insert Functions
        public bool InsertGender(Gender gender)
        {
            db.Genders.Add(gender);
            return db.SaveChanges() > 0;
        }

        public bool InsertMonsterType(MonsterType monsterType)
        {
            db.MonsterTypes.Add(monsterType);
            return db.SaveChanges() > 0;
        }

        public bool InsertTitle(Title title)
        {
            db.Titles.Add(title);
            return db.SaveChanges() > 0;
        }

        public bool InsertMonster(Monster monster)
        {
            db.Monsters.Add(monster);
            return db.SaveChanges() > 0;
        }
        #endregion

        #region Change Functions
        public bool ChangeGender(Gender gender, EntityState state)
        {
            var entry = db.Entry<Gender>(gender);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public bool ChangeMonsterType(MonsterType monsterType, EntityState state)
        {
            var entry = db.Entry<MonsterType>(monsterType);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public bool ChangeTitle(Title title, EntityState state)
        {
            var entry = db.Entry<Title>(title);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public bool ChangeMonster(Monster monster, EntityState state)
        {
            var entry = db.Entry<Monster>(monster);

            entry.State = state;
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
