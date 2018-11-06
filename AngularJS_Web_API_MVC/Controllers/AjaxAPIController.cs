using AngularJS_Web_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJS_Web_API_MVC.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/AjaxMethod")]
        [HttpPost]
        public List<Customer> AjaxMethod(CustomerModel customer)
        {
            NorthwindEntities entities = new NorthwindEntities();
            return (from c in entities.Customers.Take(10)
                    where c.ContactName.StartsWith(customer.Name)
                    select c).ToList();
        }
    }
}
