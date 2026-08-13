# BlazorApp_MEmp
It is C# Blazor Application that represent web UI framework from Microsoft that build interactive websites using C# and .NET instead of JavaScript for most of the application logic.

It was made from reusable components, somewhat like React components that is called Razor components. You will find here multiple situation for Razor components for case study.

The application made use of Restful API Service and use login for exploring data and acquire validation on Insertion, updating, and deleting actions.

For login, you can login after creating the username and password; or login using Two-factor authentication.

The data migration in BServer_EmpWeb project was done on Identity to create AspNet tables such as AspNetRoles, AspNetUsers, AspNetUserLogins, and so on...

Another data migration was done in RAPI_EmpManage project for Employees management that calls CR_Emp class controller that calls EmpCrudRepository repository class.
