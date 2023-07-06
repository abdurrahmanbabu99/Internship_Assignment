using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Intern_Assignment.Controllers
{
    public class ProductListController : ApiController
    {
        [Route("api/ProductList/Names")]
        [HttpGet]

        public List<string> GetNames()
        {
            return Mobile_Storage_Service.GetNames();
        }
        [Route("api/ProductList/All")]
        [HttpGet]
        public List<Mobile_Storage_Model> GetAll()
        {
            return Mobile_Storage_Service.Get();
        }
        [Route("api/ProductList/Create")]
        [HttpPost]

        public void Add(Mobile_Storage_Model m1)
        {
            Mobile_Storage_Service.Add(m1);
        }

    }
}
