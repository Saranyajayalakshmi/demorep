using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    public class MasterController : ApiController
    {
        Entities3 db = new Entities3();

        //Add Post Method
        public string Post(MasterT masterTS)
        {
            db.MasterTS.Add(masterTS);
            db.SaveChanges();
            return "Master Added";
        }
        //Get All Records
        public IEnumerable<MasterT>Get()
        {
            return db.MasterTS.ToList();
        }
        //Get Single Master
        public MasterT Get(int id)
        {
            MasterT masterT = db.MasterTS.Find(id);
            return masterT;
        }
        //Update the Records
        public string Put(int id,MasterT masterT)
        {
            var masterTS = db.MasterTS.Find(id);
            masterT.MName= masterT.MName;
            masterT.ExpressId= masterT.ExpressId;

            db.Entry(masterT).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Master Updated";
        }
        //Delete the Record
        public string Delete(int id)
        {
            MasterT masterT= db.MasterTS.Find(id);
            db.MasterTS.Remove(masterT);
            db.SaveChanges();
            return "Deleted";
        }

    }

}

