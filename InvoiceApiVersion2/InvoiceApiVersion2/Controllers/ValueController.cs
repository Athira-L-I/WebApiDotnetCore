//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc;

//namespace InvoiceApiVersion2.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValueController : ControllerBase
//    {
//        private IRepositoryWrapper _repoWrapper;
//        private ILoggerManager _logger;

//        public ValueController(IRepositoryWrapper wrapper, ILoggerManager logger)
//        {
//            _repoWrapper = wrapper;
//            _logger = logger;
//        }


//        // GET api/values
//        [HttpGet]
//        public ActionResult<IEnumerable<string>> Get()
//        {
//            var paramdata = _repoWrapper.Parameter.FindAll().ToList();
//           // var ruledata = _repoWrapper.Rule.
            

//            return new string[] { "value1", "value2" };
//        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public ActionResult<string> Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}