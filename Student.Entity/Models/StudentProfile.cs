using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    [FirestoreData]
    public class StudentProfile
    { 
        [FirestoreProperty]
        public  string StudentId { get; set; }
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
        public string ProfilePicture { get; set; }
        [FirestoreProperty]
        public virtual OtherStudentInformation OtherStudentInformation { get; set; }
        [FirestoreProperty]
        public ICollection<StudentEducation> StudentEducations { get; set; }
        [FirestoreProperty]
        public ICollection<StudentWorkExperience> StudentWorkExperiences { get; set; }

    }
}
