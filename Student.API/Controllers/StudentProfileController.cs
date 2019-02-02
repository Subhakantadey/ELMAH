using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;

namespace Student.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class StudentProfileController : ControllerBase
    {
        private const string ProjectId = "studentapp-cdfbd";
        FirestoreDb firestore = FirestoreDb.Create(ProjectId);
        public StudentProfileController()
        {
           
        }
       
        // GET: api/StudentProfile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StudentProfile/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentProfile
        [HttpPost]
        public void Post([FromBody] string value)
        {
            CollectionReference collection = firestore.Collection("Profile");
            
        }

        // PUT: api/StudentProfile/5
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
