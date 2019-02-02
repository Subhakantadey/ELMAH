using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    class StudentWorkExperience

    { 
        [FirestoreProperty]
        public Guid ProfileKey { get; set; }
        [FirestoreProperty]
        public string OrganisationName { get; set; }
        [FirestoreProperty]
        public string Role { get; set; }
        [FirestoreProperty]
        public string Responsibility { get; set; }
        [FirestoreProperty]
        public DateTime FromDate { get; set; }
        [FirestoreProperty]
        public DateTime ToDate { get; set; }

    }
}
