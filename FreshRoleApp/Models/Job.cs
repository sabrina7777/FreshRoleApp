using System.ComponentModel.DataAnnotations;

namespace FreshRoleApp.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Tier { get; set; }
        public string? Category { get; set; }
        public bool IsActive { get; set; }

        // Navigation property for the Users table
        public ICollection<User> Users { get; set; } = new List<User>();

        public ICollection<Job> NextJobs { get; set; } = new List<Job>();
        //public string GetNextJobsAsString()
        //{
        //    return string.Join(", ", NextJobs.Select(nj => nj.Title));
        //}

        public Job()
        {
            //fill in later 
        }
    }
}

