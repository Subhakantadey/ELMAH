using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginDetailsController : ControllerBase
    {
        private const string ProjectId = "studentapp-cdfbd";
        FirestoreDb firestore = FirestoreDb.Create(ProjectId);
       
        // GET: api/LoginDetails
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LoginDetails/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoginDetails
        [HttpPost]
        public void Post([FromBody] string value)
        {
            CollectionReference collection = firestore.Collection("LoginDetails");
        }

        // PUT: api/LoginDetails/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
