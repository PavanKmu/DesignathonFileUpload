using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Designathon.Models
{
    [Keyless]
    public class FileUploadModel
    {       
        public string Name { get; set; }
        
        public string EmailID { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public string Certifications { get; set; }
        public string InternshipDetails { get; set; }
        public string CoursesCompleted { get; set; }
        public string LinkedInProfileLink { get; set; }
        public string GithubProfileLink { get; set; }
        public string ProgrammingLanguagesKnown { get; set; }
    }
}
