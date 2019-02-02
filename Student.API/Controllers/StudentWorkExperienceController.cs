﻿using System;
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
    public class StudentWorkExperienceController : ControllerBase
    {
        private const string ProjectId = "studentapp-cdfbd";
        FirestoreDb firestore = FirestoreDb.Create(ProjectId);

        public StudentWorkExperienceController()
        {

        }

        // GET: api/StudentWorkExperience
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StudentWorkExperience/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentWorkExperience
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/StudentWorkExperience/5
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
