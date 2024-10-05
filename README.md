# Bookstore Management Platform

## Overview

This is a Bookstore Management platform built using ASP.NET Core MVC. The application provides CRUD (Create, Read, Update, Delete) functionality for managing books, including properties such as Title, Author, Price, and Genre. It also includes validation to ensure proper data entry.

## Application Setup

1. **Create a new ASP.NET Core MVC Web App project** for the Bookstore platform.

2. **Set up your database connection** using SQL Server.

3. **Install necessary NuGet packages**:
   Open the NuGet Package Manager Console and run the following commands:
   ```csharp
   Install-Package Microsoft.EntityFrameworkCore.SqlServer
   Install-Package Microsoft.EntityFrameworkCore.Tools
   Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
   Install-Package Microsoft.EntityFrameworkCore.Design
