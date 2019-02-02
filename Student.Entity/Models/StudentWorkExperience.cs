using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    public class StudentWorkExperience

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
        public Int16 FromMonth { get; set; }
        [FirestoreProperty]
        public Int16 FromYear { get; set; }
        [FirestoreProperty]
        public Int16 ToMonth { get; set; }
        [FirestoreProperty]
        public Int16 ToYear { get; set; }

    }

}
