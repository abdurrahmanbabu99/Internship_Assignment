using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product_Repo
    {
        static Internship_AssignmentEntities db;

        static Product_Repo()
        {
            db = new Internship_AssignmentEntities();
        }
        public static List<Mobile_Storage> Get()
        {
            return db.Mobile_Storage.ToList();
        }
        public static Mobile_Storage Get(int id)
        {
            return db.Mobile_Storage.FirstOrDefault(x => x.Id == id);   
        }
        public static void Edit(Mobile_Storage ms)
        {
            var ds = db.Mobile_Storage.FirstOrDefault(x => x.Id == ms.Id);
            db.Entry(ds).CurrentValues.SetValues(ms);
            db.SaveChanges();   
        }
        public static void Delete(int id)
        {
            var ds = db.Mobile_Storage.FirstOrDefault(x => x.Id == id);
            db.Mobile_Storage.Remove(ds);   
        }

        public static void Add(Mobile_Storage ms)
        {
            db.Mobile_Storage.Add(ms);
            db.SaveChanges();
        }




    }
}
