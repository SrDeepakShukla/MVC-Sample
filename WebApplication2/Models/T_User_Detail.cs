using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class T_User_Detail
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        public string Description { get; set; }
       
    }

    public class T_User_DetailMethods
    {
        public bool SaveRecord(T_User_Detail user)
        {
            try
            {
                ApplicationDbContext db = new Models.ApplicationDbContext();


                db.T_User_Details.Add(user);
                db.SaveChanges();
                return true;
    
            }
            catch(Exception ex
            )
            {
                return false;
            }
        }
    }
}