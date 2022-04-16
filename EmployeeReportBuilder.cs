namespace Reporter
    // реализуем строителя в соотвествии с этим интерфейсом 
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport; // приватное поле это отчет который мы будем строить

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees) // список сотрудников котрый мы будем получать в отчете
        {
            _employees = employees; // присвоим параметры приватным полям класса 
            _employeeReport = new();
        }

        public IEmployeeReportBuilder BuildHeader() // тут заголовок отчета с затой чтобы было красиво 
        {
            _employeeReport.Header =
                $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";

            _employeeReport.Header +=
                "\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IEmployeeReportBuilder BuildBody() // вывод имен сотрудников с зп  
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                    _employees.Select(e =>
                    $"Employee: {e.Name}\t\tSalary: {e.Salary}$"));

            return this;
        }

        public IEmployeeReportBuilder BuildFooter() // нижний клантитул отчета с кол во сотрудниками и зп
        {
            _employeeReport.Footer =
                "\n----------------------------------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\nTOTAL EMPLOYEES: {_employees.Count()}, " +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";

            return this;
        }

        public EmployeeReport GetReport() // возвращение созданного объекта 
        {
            EmployeeReport employeeReport = _employeeReport; // сохраняем во временную переменную 

            _employeeReport = new(); // ну и обновляем в приватном поле для след обращений 

            return employeeReport;
        }
    }
}
