# FreshRoleApp
Description: 
This is a .net Model View Controller project built using Razor pages. 
The app is currentily built for an admin to create, edit, view and delete job roles within a company. The user can view each job description. 

Instructions:
Pull the code from GitHub and open in Visual Studio (e.g. copy HTTP and clone the repo, or open with Visual Studio)
In the VS Toolbar, change the run to IIS Expres. 
Run the app. Click the "Job" header which will display the database migration message. 
Do one of the following: 
- Click the "Apply Migration" button
- Go to the Package Manager Console in VS and run the command, "update-datebase" (relaunch the app) or enter the command "dotnet ef database update" in Command Prompt

When you launch the app, click on the "Job" header and there should be populated job data. 


Requirements Met:
Make your application an API
Make your application a CRUD API (The "Controllers" classes with the HTTP requests do this: they create, read, update, and delete info from the job class)
Make your application asynchronous (A lot of the Controller methods are async)
Add a comment for where I used a SOLID principle
TBD: Create 3 or more unit tests for your application
Add visual appeal (generated logo, color)