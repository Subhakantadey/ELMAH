using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    public class LoginDetails
    {
        [FirestoreProperty]
        public string UserId { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string IPAddress { get; set; }
        [FirestoreProperty]
        public DateTime LoginTime { get; set; }


    }
}
 