# ProductApp - Enterprise Management System

A comprehensive ASP.NET MVC web application for managing products, employees, and departments with advanced reporting capabilities. Built with modern web technologies and Oracle database integration.

## 🚀 Features

### Core Functionality
- **Product Management**: Complete CRUD operations for product inventory
- **Employee Management**: Employee records with department associations
- **Department Management**: Organizational structure management
- **Advanced Reporting**: Interactive dashboards and trend analysis

### Key Features
- **Oracle Database Integration**: Robust data persistence with Oracle 23c
- **Entity Framework 6**: Modern ORM with code-first approach
- **Responsive UI**: Bootstrap 5.2.3 for mobile-friendly design
- **AJAX-powered**: Dynamic content loading and real-time updates
- **Data Visualization**: Interactive charts and trend analysis
- **Filtering & Search**: Advanced filtering capabilities for reports

## 🛠 Technology Stack

### Backend
- **Framework**: ASP.NET MVC 5.2.9 (.NET Framework 4.7.2)
- **Database**: Oracle Database 23c with Oracle Managed Data Access
- **ORM**: Entity Framework 6.5.1
- **Language**: C# 7.0+

### Frontend
- **CSS Framework**: Bootstrap 5.2.3
- **JavaScript Libraries**: 
  - jQuery 3.7.0
  - jQuery Validation 1.19.5
  - Modernizr 2.8.3
- **UI Components**: Responsive grid system and utilities

### Development Tools
- **Package Manager**: NuGet
- **Build System**: MSBuild
- **IDE Support**: Visual Studio 2019/2022

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- **Visual Studio 2019** or **Visual Studio 2022** (Community/Professional/Enterprise)
- **Oracle Database 23c** (or compatible version)
- **Oracle Client** (for database connectivity)
- **.NET Framework 4.7.2** or later
- **IIS Express** (included with Visual Studio)

## 🔧 Installation & Setup

### 1. Clone the Repository
```bash
git clone <repository-url>
cd ProductApp
```

### 2. Database Setup
1. **Install Oracle Database** (if not already installed)
2. **Create Database Schema**:
   ```sql
   -- Connect to Oracle as SYSTEM user
   CREATE USER productapp IDENTIFIED BY your_password;
   GRANT CONNECT, RESOURCE TO productapp;
   GRANT CREATE SESSION TO productapp;
   ```

### 3. Configure Connection String
Update the connection string in `Web.config`:
```xml
<connectionStrings>
    <add name="OracleDbContext" 
         providerName="Oracle.ManagedDataAccess.Client" 
         connectionString="User Id=your_username;Password=your_password;Data Source=localhost:1521/XEPDB1"/>
</connectionStrings>
```

### 4. Restore NuGet Packages
1. Open the solution in Visual Studio
2. Right-click on the solution in Solution Explorer
3. Select "Restore NuGet Packages"

### 5. Build and Run
1. **Build the Solution**: `Ctrl + Shift + B`
2. **Run the Application**: `F5` or click "Start Debugging"

## 📁 Project Structure

```
ProductApp/
├── Controllers/           # MVC Controllers
│   ├── HomeController.cs
│   ├── ProductController.cs
│   ├── EmployeeController.cs
│   └── ReportsController.cs
├── Models/               # Data Models & DbContext
│   ├── AppDbContext.cs
│   ├── Product.cs
│   ├── Employee.cs
│   └── Department.cs
├── Views/               # Razor Views
│   ├── Home/
│   ├── Product/
│   ├── Employee/
│   └── Reports/
├── Content/             # CSS & Static Assets
├── Scripts/             # JavaScript Files
├── App_Start/           # Application Configuration
└── Web.config          # Application Settings
```

## 🗄 Database Schema

### Products Table
- `Id` (Primary Key)
- `Name` (Product Name)
- `Price` (Decimal)
- `Quantity` (Integer)

### Employees Table
- `Id` (Primary Key)
- `Name` (Required)
- `Salary` (Required, Decimal)
- `DepartmentId` (Foreign Key)
- `Role` (String)
- `Location` (String)
- `DateOfJoining` (DateTime)

### Departments Table
- `DepartmentId` (Primary Key)
- `DepartmentName` (Required)
- `Name` (String)

## 🎯 Usage Guide

### Product Management
- **View Products**: Navigate to `/Product` to see all products
- **Add Products**: Use the product management interface
- **Update/Delete**: Available through the product listing

### Employee Management
- **View Employees**: Navigate to `/Employee` for employee listing
- **Employee Data**: Includes salary, department, role, and location
- **Department Association**: Employees are linked to departments

### Reporting & Analytics
- **Trends Dashboard**: Navigate to `/Reports/Trends`
- **Employee Trends**: 30-day employee joining trends
- **Filtering Options**: Filter by department, role, and location
- **Interactive Charts**: Visual representation of data

### API Endpoints
- `GET /Employee/GetEmployees` - Returns employee data as JSON
- `GET /Reports/GetDailyEmployeeTrend` - Employee trend data
- `GET /Reports/GetEmployeeFilters` - Available filter options

## 🔒 Security Considerations

- **Database Security**: Use strong passwords for database access
- **Connection String**: Store sensitive information securely
- **Input Validation**: Client and server-side validation implemented
- **SQL Injection**: Protected through Entity Framework ORM

## 🚀 Deployment

### Production Deployment
1. **Build in Release Mode**: `Ctrl + Shift + B` (Release configuration)
2. **Publish to IIS**: Use Visual Studio's publish feature
3. **Configure IIS**: Set up application pool and website
4. **Database Migration**: Ensure database schema is up-to-date

### Environment Configuration
- **Development**: Uses IIS Express with debug mode
- **Production**: Configure for IIS with optimized settings
- **Database**: Ensure Oracle client is installed on production server

## 🐛 Troubleshooting

### Common Issues

**Database Connection Error**
- Verify Oracle client installation
- Check connection string in `Web.config`
- Ensure database service is running

**Build Errors**
- Restore NuGet packages
- Clean and rebuild solution
- Check .NET Framework version compatibility

**Runtime Errors**
- Check application logs
- Verify database permissions
- Ensure all dependencies are installed

## 📊 Performance Optimization

- **Database Indexing**: Optimize queries with proper indexes
- **Caching**: Implement caching for frequently accessed data
- **Bundle Optimization**: CSS and JS files are bundled and minified
- **Database Connection Pooling**: Configured in Entity Framework

## 📊 Data Visualizations

We have integrated multiple interactive charts using **Plotly.js** to provide insights into software metrics and bug data:

- **Bug Frequency Pie Chart:** Shows the ratio of buggy vs clean classes.
- **LOC vs Bug Count Bar Chart:** Compares lines of code to number of bugs.
- **Bug Density Chart:** Displays average bug count per KLOC per class.
- **Filtered Charts:** Users can filter charts by Department, Role, and Location for targeted analysis.

These charts are dynamically rendered and fetch data from the server using AJAX endpoints in the `ChartsController`. The dashboard now offers a more data-driven perspective on software quality.

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support

For support and questions:
- Create an issue in the repository
- Contact the development team
- Check the troubleshooting section above

## 🔄 Version History

- **v1.0.0** - Initial release with basic CRUD operations
- **v1.1.0** - Added reporting and analytics features
- **v1.2.0** - Enhanced UI with Bootstrap 5.2.3
- **v1.3.0** - Oracle database integration and performance improvements

---

**Built with ❤️ using ASP.NET MVC and Oracle Database**

