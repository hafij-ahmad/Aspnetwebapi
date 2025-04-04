using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAcess;

namespace EmployeeServices.Controllers
{
    public class EmployeeController : ApiController
    {
        //WebApiEntities Entity = new WebApiEntities();
        public IEnumerable<Employe> Get()
        {

            using (WebApiEntities1 entities = new WebApiEntities1())
            {

                return entities.Employes.ToList();
            }
        }
        public Employe Get(int id)
        {
            using(WebApiEntities1 entities1= new WebApiEntities1())
            {
                var model=entities1.Employes.FirstOrDefault(e => e.ID == id);
                return model;
            }
        }

    }
}
    
