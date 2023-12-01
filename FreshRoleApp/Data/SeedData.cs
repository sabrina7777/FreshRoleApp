using FreshRoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshRoleApp.Data
{
    //SOLID EXAMPLE: Example of Single Responsbility Principle (SRP). The SeedData class is only for seeding data at the beginning of launching the app. 
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
                Description = "Makes all the decisions in creative and effective ways.",
                Tier = 5,
                Category = "Technical",
                IsActive = true
            },
            new Job()
            {
                Title = "Training Manager",
                Description = "Provides high-quality software training to the comapny’s extensive customer base as well as internal employees.",
                Tier = 4,
                Category = "Customer Focus",
                IsActive = true
            },
            new Job()
            {
                Title = "Training Specialist",
                Description = "Provides exceptional software and business skills training to both employees and customers.",
                Tier = 3,
                Category = "Customer Focus",
                IsActive = true
            },
            new Job()
            {
                Title = "QA",
                Description = "Initiates tests, analyzes results, isolates issues and finds solutions to technical problems.",
                Tier = 3,
                Category = "Technical",
                IsActive = true
            },
            new Job()
            {
                Title = "Implementation Specialist",
                Description = "Is the primary point of contact for new customers during their transition to the software.",
                Tier = 2,
                Category = "Customer Focus",
                IsActive = true
            },
            new Job()
            {
                Title = "HR Generalist",
                Description = "Is the primary point of contact for employees to ask HR-related questions.",
                Tier = 1,
                Category = "Operations",
                IsActive = true
            },

            new Job()
            {
                Title = "Support Specialist",
                Description = "Provides support to customer base; assumes ownership of assigned support cases and will follow through until the case has been closed.",
                Category = "Customer Focus",
                Tier = 1,
                IsActive = true,
                NextJobs = new List<Job>
                //attemping to figure out NextJob link in SeedData
                {
                     new Job()
                     {
                           Title = "Support Team Lead",
                           Description = "Provide guidance, instruction, direction and leadership to the Product Support Specialists who are primarily responsible for resolution of assigned product support cases. \r\n",
                           Tier = 2,
                           Category = "Customer Focus",
                           IsActive = true,
                     },
                }
            }


        };

            context.Jobs.AddRange(jobs);
            // Make all of the jobs.
            context.SaveChanges();

            //attempting to figure out how to use Dictionary in SeedData
            Dictionary<string, Job> jobsDict = jobs.ToDictionary(j => j.Title, j => j);

            // Setup the connections (link a job to an existing job already created)
            jobsDict["Training Manager"].NextJobs.Add(jobsDict["CEO"]);
            jobsDict["Training Specialist"].NextJobs.Add(jobsDict["Training Manager"]);
            jobsDict["Implementation Specialist"].NextJobs.Add(jobsDict["Training Specialist"]);
            //This line below errors as Support Team Lead not present in the Dictionary - must click Continue for app to load so removing
           //jobsDict["Support Team Lead"].NextJobs.Add(jobsDict["Implementation Specialist"]);
            jobsDict["Support Specialist"].NextJobs.Add(jobsDict["Support Team Lead"]);

            context.Jobs.UpdateRange(jobsDict.Values);
            context.SaveChanges();
        }
    }
}