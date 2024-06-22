# Back Office

Package NuGets
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet aspnet-codegenerator razorpage -m User -dc ApplicationDbContext -outDir Pages/Users --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Job -dc ApplicationDbContext -outDir Pages/Jobs --referenceScriptLibraries
dotnet aspnet-codegenerator razorpage -m Interview -dc ApplicationDbContext -outDir Pages/Interviews --referenceScriptLibraries

# Front Office

Package NuGets
Microsoft.Data.SqlClient
