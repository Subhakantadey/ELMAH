using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Entity.Models
{
    class LoginDetails
    {
    }
    [FirestoreData]
    class OtherStudentInformation
    {
        [FirestoreProperty]
        public string AreaOfInterest { get; set; }
        [FirestoreProperty]
        public string Accomplishment { get; set; }
        [FirestoreProperty]
        public string Skills { get; set; }
    }
}
