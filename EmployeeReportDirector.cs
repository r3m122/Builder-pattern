namespace Reporter
    // создаем директора 
{
    public class EmployeeReportDirector
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirector(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build() // ну и построение отчета 
        {
            _builder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
