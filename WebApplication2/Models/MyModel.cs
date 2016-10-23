using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MyModel
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public List<MyUsers> GetUsers()
        {

            List<MyUsers> mm = new List<MyUsers>();
            mm.Add(new MyUsers { Id = 1, Name = "Raz" });
            mm.Add(new MyUsers { Id = 2, Name = "Om" });
            mm.Add(new MyUsers { Id = 3, Name = "Hari" });
            mm.Add(new MyUsers { Id = 4, Name = "ZYZ" });
            mm.Add(new MyUsers { Id = 5, Name = "Shyam" });
            return mm;
        }
        public MyUsers GetUserFromId(int id)
        {

            MyUsers my = new Models.MyUsers();
            my.Id = id;
            return my;


        }
    }

}