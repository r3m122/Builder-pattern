using Reporter;

List<Employee> employees = new() // создаем список сотрудников с зп
{
    new Employee { Name = "Ivan", Salary = 100 },
    new Employee { Name = "Boris", Salary = 50 },
    new Employee { Name = "Ashot", Salary = 200 }
};

var builder = new EmployeeReportBuilder(employees); // передаем сотрудников 

var director = new EmployeeReportDirector(builder);

director.Build(); // директор строит отчет 

var report = builder.GetReport(); // получаем отчет 

Console.WriteLine(report);

Console.ReadKey();