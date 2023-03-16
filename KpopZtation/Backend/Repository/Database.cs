using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Repository
{ 
    public class Database
    {
        private static Entities db = null;
        
        private Database()
        {

        }

        public static Entities GetInstance()
        {
            if(db == null)
            {
                db = new Entities();
            }
            return db;
        }

        public static void SecureSave()
        {
            // Secure Save if failed, will not break the code!

            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}