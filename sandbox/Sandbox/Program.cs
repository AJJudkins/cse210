using System;

class Program
{
    static void Main(string[] args)
    {
        var hourly = new HourlyEmployee(100, "Elon Musk", 14);
        var salary = new SalaryEmployee(90000, "Austin Judkins", 14);

        var employess = new List<Employee> {hourly, salary};

        foreach (var employee in employess)
        {
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.PayPeriodWages());
        }
    }
}

class Employee
{
    public string _name;

    protected double _payPeriod;

    public Employee(string name, int payPeriod)
    {
        _name = name;
        _payPeriod = payPeriod;
    }

    virtual public double PayPeriodWages()
    {
        return 0;
    }
}


class HourlyEmployee: Employee
{
    double _rate;

    public HourlyEmployee(double rate, string name, int payPeriod): base(name, payPeriod)
    {
        _rate = rate;
    }
    public override double PayPeriodWages()
    {
        return _rate * 8 *_payPeriod;
    }
}

class SalaryEmployee : Employee
{
    double _annualRate;

    public SalaryEmployee(double annualRate, string name, int payPeriod): base(name, payPeriod)
    {
        _annualRate = annualRate;
    }

    public override double PayPeriodWages()
    {
        return (_payPeriod / 365) * _annualRate;
    }

}