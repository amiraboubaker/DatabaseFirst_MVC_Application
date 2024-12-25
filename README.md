
# 🌟 DatabaseFirst MVC Application  

Welcome to the **DatabaseFirst_MVC_Application**! 🎉 This project demonstrates how to use the **Database-First** approach with Entity Framework Core in an MVC application. 🚀  

### 🛠️ Generating the `MenuContext` and Models  
To get started, generate the database context and models in just one simple step! Here's the command you need to run in the **NuGet Package Manager Console**:  

### In Nuget Console:
Tap this command : 
#### Scaffold-DbContext "Data Source=YourDesktop_Name;Initial Catalog=Menu;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotations
✨ Quick Tips:
💡 ContextDir: Places the generated context file in the Data folder for better organization.
📂 OutputDir: Stores the generated models in the Models folder for a clean and structured project.
🏷️ DataAnnotations: Includes attributes in your models to keep things well-defined and precise!
🎈 Happy Coding!
Let’s bring your database to life in your MVC application! If you have any questions or run into any issues, don’t hesitate to explore, learn, and have fun! 🌟
