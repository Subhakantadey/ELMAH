using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherStudentInformationController : ControllerBase
    {
        private const string ProjectId = "studentapp-cdfbd";
        FirestoreDb firestore = FirestoreDb.Create(ProjectId);
        // GET: api/OtherStudentInformation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OtherStudentInformation/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OtherStudentInformation
        [HttpPost]
        public async void asyncPost([FromBody] string value)
        {
            CollectionReference collection = firestore.Collection("OtherStudentInformationController");
            DocumentReference document = await collection.AddAsync(value);
        }

        // PUT: api/OtherStudentInformation/5
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
