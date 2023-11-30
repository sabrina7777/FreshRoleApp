using FreshRoleApp.Models;

namespace FreshRoleApp.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context == null || context.Jobs == null)
            {
                throw new ArgumentNullException("Null ApplicationDbContext");
            }

            // Look for any jobs.
            if (context.Jobs.Any())
            {
                return;   // DB has been seeded
            }
            // Create all of the jobs up front:
            List<Job> jobs = new List<Job>
        {
            new Job
            {
                Title = "CEO",
                Description = "Makes all the decisions in creative and effective ways. ",
                Category = "Technical",
                IsActive = true
            },
            new Job()
            {
                Title = "Training Manager",
                Description = "Provides high-quality Rent Manager software training to LCS’s extensive customer base as well as internal employees.  ",
                Category = "Customer Focus",
                IsActive = true
            },
            new Job()
            {
                Title = "Training Specialist",
                Description = "Provides exceptional RM and business skills training to both employees and customers.",
                Category = "Customer Focus",
                IsActive = true
            },
            new Job()
            {
                Title = "QA",
                Description = "Initiates tests, analyzes results, isolates issues and finds solutions to technical problems. ",
                Category = "Technical",
                IsActive = true
            },
            new Job()
            {
                Title = "Implementation Specialist",
                Description = "Is the primary point of contact for new customers during their transition to Rent Manager.",
                Category = "Customer Focus",
                IsActive = true
            },

            new Job()
            {
                Title = "Support Specialist",
                Description = "Provides support to customer base; assumes ownership of assigned support cases and will follow through until the case has been closed.",
                Category = "Customer Focus",
                IsActive = true,
                NextJobs = new List<Job>
                {
                     new Job()
                     {
                           Title = "Support Team Lead",
                           Description = "Provide guidance, instruction, direction and leadership to the Product Support Specialists who are primarily responsible for resolution of assigned product support cases. \r\n",
                            Category = "Customer Focus",
                            IsActive = true,
                     },
                }
            }


        };

            context.Jobs.AddRange(jobs);
            // Make all of the jobs.
            context.SaveChanges();

            Dictionary<string, Job> jobsDict = jobs.ToDictionary(j => j.Title, j => j);

            // Setup the connections however you'd like.
            jobsDict["Training Manager"].NextJobs.Add(jobsDict["CEO"]);
            jobsDict["Training Specialist"].NextJobs.Add(jobsDict["Training Manager"]);
            jobsDict["Implementation Specialist"].NextJobs.Add(jobsDict["Training Specialist"]);
            jobsDict["Support Team Lead"].NextJobs.Add(jobsDict["Training Specialist"]);
            jobsDict["Support Team Lead"].NextJobs.Add(jobsDict["Implementation Specialist"]);
            jobsDict["Support Specialist"].NextJobs.Add(jobsDict["Support Team Lead"]);

            context.Jobs.UpdateRange(jobsDict.Values);
            context.SaveChanges();
        }
    }
}