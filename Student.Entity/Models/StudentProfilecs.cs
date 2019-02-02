using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    class StudentProfilecs
    {
        [FirestoreProperty]
        public Guid ProfileKey { get; set; }
        [FirestoreProperty]
        public  int StudentId { get; set; }
        [FirestoreProperty]
        public string FirstName { get; set; }
        [FirestoreProperty]
        public string MiddleName { get; set; }
        [FirestoreProperty]
        public string LastName { get; set; }
        [FirestoreProperty]
        public string EmailId { get; set; }
        [FirestoreProperty]
        public string PhoneNumber { get; set; }
        [FirestoreProperty]
        public string Address { get; set; }
        [FirestoreProperty]
        public string ProfilePicture { get; set; }

    }
}
