using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP_CoreRazorContoso.Models
{
    public class Student
    {
        //Database Attributes
        public int StudentID { get; set; }

        [Required, StringLength(20, ErrorMessage ="Please do not enter more than 20 characters.")]
        public string FirstName { get; set; }

        [Required, StringLength(20, ErrorMessage = "Please do not enter more than 20 characters.")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        //Navigatiobn Properties (relationship)
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public string FullName()
        {
            return FirstName + " "+ LastName;
        }
    }
}
