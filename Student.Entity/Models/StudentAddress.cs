using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
        [FirestoreData]
        public class StudentAddress
        {
            [FirestoreProperty]
            public int StudentId { get; set; }
            [FirestoreProperty]
            public string StreetName { get; set; }
            [FirestoreProperty]
        public string City { get; set; }
            [FirestoreProperty]
            public string State { get; set; }
            [FirestoreProperty]
            public int ZipCode { get; set; }
            [FirestoreProperty]
            public string Country { get; set; }
        }
    
}
