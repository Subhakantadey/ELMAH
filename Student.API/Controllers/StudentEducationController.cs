using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Student.Entity.Models;

namespace Student.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentEducationController : ControllerBase
    {

        private const string ProjectId = "studentapp-cdfbd";
        public FirestoreDb db;
        QuerySnapshot allProfile;
        CollectionReference collection;
        public StudentEducationController()
        {
            db = FirestoreDb.Create(ProjectId);
            collection = db.Collection("Profile");
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", ProjectId);
        }
        // GET: api/StudentEducation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StudentEducation/5
        [HttpGet("{id}")]
        public async Task<StudentWorkExperience> GetAsync(string id)
        {
            allProfile = await collection.GetSnapshotAsync();
            StudentWorkExperience studentWorkExperience = new StudentWorkExperience();
            foreach (DocumentSnapshot document in allProfile.Documents)
            {
                if(document.Id == id)
                {
                    return studentWorkExperience = document.GetValue<StudentWorkExperience>("StudentWorkExperience");
                }
            }
            return null;
        }

        // POST: api/StudentEducation
        [HttpPost("{id}")]
        public async Task<string> PostAsync(string id,[FromBody] StudentWorkExperience value)
        {
            DocumentReference document = db.Collection("Profile").Document(id);
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            if(snapshot.GetValue<StudentWorkExperience>("StudentWorkExperience")==null)
            {
                Dictionary<FieldPath, object> updates = new Dictionary<FieldPath, object>
                {
                    { new FieldPath("StudentWorkExperience"), value }
                };
                await document.UpdateAsync(updates);
                return "Successfully Inserted";
            }
            return "Already Exist";
        }

        // PUT: api/StudentEducation/5
        [HttpPut("{id}")]
        public async Task PutAsync(string id, [FromBody] StudentWorkExperience value)
        {
            var json = JsonConvert.SerializeObject(value);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            DocumentReference document = db.Collection("Profile").Document(id);

            await document.UpdateAsync(dictionary);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(string id)
        {
            DocumentReference document = db.Collection("Profile").Document(id);
            Dictionary<string, object> updates = new Dictionary<string, object>
            {
                { "StudentWorkExperience", FieldValue.Delete }
            };
            await document.UpdateAsync(updates);
        }
    }
}
