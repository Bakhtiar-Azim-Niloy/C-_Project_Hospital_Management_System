using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Patient : Person
    {
        public int Age { get; set; }
        public string ChckInDate { get; set; }
        public string Consultant { get; set; }
        public string PatientType { get; set; }
        public string RoomType { get; set; }
        public string RoomNo { get; set; }
        public string charge { get; set; }
        public string CheckOutDate { get; set; }
        public string Diagnosis { get; set; }
        public string ReadyToRelease { get; set; }
        public string Sypmtoms { get; set; }
        public string Prescription { get; set; }
        public string Status { get; set; }
    }
}
