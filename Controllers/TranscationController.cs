using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    public class TranscationController : ApiController
    {
        Entities4 db = new Entities4();

        //Add Post Method
        public string Post(Transc transc)
        {
            db.Transcs.Add(transc);
            db.SaveChanges();
            return "Transcation Added";
        }
        //Get All Records
        public IEnumerable<Transc> Get()
        {
            return db.Transcs.ToList();
        }
        //Get Single Master
        public Transc Get(int id)
        {
            Transc transc = db.Transcs.Find(id);
            return transc;
        }
        //Update the Records
        public string Put(int id, Transc transc)
        {
            var trans = db.Transcs.Find(id);
            trans.Descrip= transc.Descrip;
            trans.TEXpress= transc.TEXpress;

            db.Entry(transc).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Transaction Updated";
        }
        //Delete the Record
        public string Delete(int id)
        {
           Transc transc = db.Transcs.Find(id);
            db.Transcs.Remove(transc);
            db.SaveChanges();
            return "Deleted";
        }
    }
}
