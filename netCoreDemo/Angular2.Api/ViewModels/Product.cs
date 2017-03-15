using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2.Api.ViewModels
{
    public class Chanpin
    {
        //{id:1,type:"e0",name:"e",clz:"e",org:"e",
        //licnum:"000",startyear:"2000",endyear:"2000",
        //quailty:"e",netwt:"e",appronum:"111",approyear:"1555" },
        public int id { get; set; }
        public string type { get; set;}
        public string name { get; set; }
        public string clz { get; set; }
        public string org { get; set; }
        public string licnum { get; set; }
        public string startyear { get; set; }
        public string endyear { get; set; }
        public string quailty { get; set; }
        public string netwt { get; set; }
        public string appronum { get; set; }
        public string approyear { get; set; }
    }
}
