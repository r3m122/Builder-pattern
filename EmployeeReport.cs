using System.Text;
// класс отчета о сотрудниках 

namespace Reporter
{
    public class EmployeeReport
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        // переопределяем метод ToString для выовода на консоль 
        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }
}
