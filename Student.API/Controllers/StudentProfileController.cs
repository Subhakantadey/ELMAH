using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Student.Entity.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentProfileController : ControllerBase
    {
        private const string ProjectId = "studentapp-cdfbd";
        public FirestoreDb db;
        QuerySnapshot allProfile;
        CollectionReference collection;

        public StudentProfileController()
        {
            db = FirestoreDb.Create(ProjectId);
            collection = db.Collection("Profile");
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", ProjectId);
        }

        // GET: api/StudentProfile
        [HttpGet]
        public async System.Threading.Tasks.Task<List<StudentProfile>> GetAsync()
        {
            List<StudentProfile> profiles = new List<StudentProfile>();
            allProfile = await collection.GetSnapshotAsync();
            Console.WriteLine(allProfile);
            foreach (DocumentSnapshot document in allProfile.Documents)
            {
                
                // Do anything you'd normally do with a DocumentSnapshot
                StudentProfile Profile = document.ConvertTo<StudentProfile>();
                profiles.Add(Profile);
            }
            return profiles;
        }

        // GET: api/StudentProfile/5
        [HttpGet("{id}")]
        public async System.Threading.Tasks.Task<StudentProfile> GetAsync(string id)
        {
            allProfile=await collection.GetSnapshotAsync();
            StudentProfile Profile = new StudentProfile();
            foreach (DocumentSnapshot document in allProfile.Documents)
            {
                if(document.Id==id)
                {
                    return Profile = document.ConvertTo<StudentProfile>();
                }
                    
            }
            return null;
        }

        // POST: api/StudentProfile
        [HttpPost]
        public async Task<string> PostAsync([FromBody] StudentProfile value)
        {
            
            DocumentReference document = await collection.AddAsync(value);
            Console.WriteLine(document.Id);
            return document.Id;

        }

        // PUT: api/StudentProfile/5
        [HttpPut("{id}")]
        public Dictionary<string, object> PutAsync(string id, [FromBody] StudentProfile value)
        {
            var json = JsonConvert.SerializeObject(value);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            DocumentReference document = db.Collection("Profile").Document(id);
            
            document.UpdateAsync(dictionary);
            return dictionary;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async System.Threading.Tasks.Task DeleteAsync(string id)
        {
            DocumentReference document = db.Collection("Profile").Document(id);
            await document.DeleteAsync();
        }
    }
}
