using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    public class OtherStudentInformation
    {
        [FirestoreProperty]
        public string AreaOfInterest { get; set; }
        [FirestoreProperty]
        public string Accomplishment { get; set; }
        [FirestoreProperty]
        public string Skills { get; set; }
    }
}
