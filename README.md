# FreshRoleApp
Description: 
This is a .net Model View Controller project built using Razor pages. 
The app is currently built for an admin to create, edit, view and delete job roles within a company. The user can view each job description. 

Instructions:
Verify you have .NET 8 installed. 
Download: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
Video tutorial: https://www.youtube.com/watch?v=CxcTlqcHAA0
Verify you have SQL installed. 

Pull the code from GitHub and open it in Visual Studio 2022 (e.g. copy HTTP and clone the repo, or open it with Visual Studio).
In the VS Toolbar, change the run to IIS Express. 
Click IIS Express to run the app. 
Click the "Job" header which will display the database migration message. 
Do one of the following: 
- Click the "Apply Migration" button
- Go to the Package Manager Console in VS and run the command, "update-database" (relaunch the app) or enter the command "dotnet ef database update" in Command Prompt

When you launch the app, click on the "Job" header and there should be populated job data. 


Requirements Met:
Make your application an API
Make your application a CRUD API (The "Controllers" classes with the HTTP requests do this: they create, read, update, and delete info from the job class)
Make your application asynchronous (A lot of the Controller methods are async)
Add a comment for where I used a SOLID principle
Add visual appeal (generated logo, color)
