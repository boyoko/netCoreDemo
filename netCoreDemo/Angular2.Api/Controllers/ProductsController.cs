using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Angular2.Api.ViewModels;
using Microsoft.AspNetCore.Cors;

namespace Angular2.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/Products")]
    [EnableCors("AllowSameDomain")]
    public class ProductsController : Controller
    {
        //public IEnumerable<Chanpin> GetAll()
        //{
        //    //{id:1,type:"e0",name:"e",clz:"e",org:"e",
        //    //licnum:"000",startyear:"2000",endyear:"2000",
        //    //quailty:"e",netwt:"e",appronum:"111",approyear:"1555" },
        //    var productList = new List<Chanpin>
        //    {
        //        new Chanpin
        //        {
        //            id=1,
        //            type = "e0",
        //            name="aa",
        //            clz = "cc",
        //            org="znjb",
        //            licnum = "0001",
        //            startyear = "2015",
        //            endyear = "2020",
        //            quailty = "1000",
        //            netwt = "asd",
        //            appronum = "90",
        //            approyear = "2020"
        //        },
        //        new Chanpin
        //        {
        //            id=2,
        //            type = "e1",
        //            name="aa1",
        //            clz = "cc1",
        //            org="znjb",
        //            licnum = "0002",
        //            startyear = "2015",
        //            endyear = "2020",
        //            quailty = "1001",
        //            netwt = "asd1",
        //            appronum = "91",
        //            approyear = "2021"
        //        }
        //    };

        //    return productList;
        //}
        [HttpGet]
        public IActionResult GetAll()
        {
            var productList = new List<Chanpin>
            {
                new Chanpin
                {
                    id=1,
                    type = "e0",
                    name="aa",
                    clz = "cc",
                    org="znjb",
                    licnum = "0001",
                    startyear = "2015",
                    endyear = "2020",
                    quailty = "1000",
                    netwt = "asd",
                    appronum = "90",
                    approyear = "2020"
                },
                new Chanpin
                {
                    id=2,
                    type = "e1",
                    name="aa1",
                    clz = "cc1",
                    org="znjb",
                    licnum = "0002",
                    startyear = "2015",
                    endyear = "2020",
                    quailty = "1001",
                    netwt = "asd1",
                    appronum = "91",
                    approyear = "2021"
                }
            };

            return Ok(productList);
        }
    }
}