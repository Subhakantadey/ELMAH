using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{

    [FirestoreData]
    public class StudentEducation
    {
        [FirestoreProperty]
        public string SchoolName { get; set; }
        [FirestoreProperty]
        public string Specialization { get; set; }
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
