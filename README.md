# FreshRoleApp
Description: 
This is a .net Model View Controller project built using Razor pages. 
The app is currently built for a user to create, edit, view and delete job roles within a company. The user can view each job description. 

Instructions:
- Verify you have .NET 8 installed. 
- Download: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Video tutorial: https://www.youtube.com/watch?v=CxcTlqcHAA0
- Verify you have SQL installed. 

1. Pull the code from GitHub and open it in Visual Studio 2022 (e.g. copy HTTP and clone the repo, or open it with Visual Studio).
2. Go to the Package Manager Console in VS and run the command, "update-database".
3. In the VS Toolbar, change the run to IIS Express. 
4. Click IIS Express to run the app. 
4. Click the "Job" header. 
    NOTE: If it displays the database migration message, click the "Apply Migration" button and relaunch the app. 
    If that doesn’t work enter the command "dotnet ef database update" in Command Prompt.
6. Populated job data should display. 
7. Actions on Jobs page:
    Create New to create a new job. 
    Edit to make a change. 
    Details to view job information for one role at a time. 
    Delete to delete the job. 
8. Click the "Search" to enter a job title and it will see if any job title matches.
    Enter "support" and it should display two titles: Support Specialist and Support Team Lead.


Requirements Met:
- Make your application an API
- Make your application a CRUD API (The "Controllers" classes with the HTTP requests do this: they create, read, update, and delete info from the job class)
- Make your application asynchronous (A lot of the Controller methods are async)
- Add a comment for where I used a SOLID principle
- Add visual appeal (generated logo, color)
