namespace Assignment3;

public abstract class Person
{
    private string name;
    private DateTime birthDate;
    private decimal salary;
    private string[] addresses;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative");
            salary = value;
        }
    }

    public string[] Addresses
    {
        get { return addresses; }
        set { addresses = value; }
    }

    public int CalculateAge()
    {
        var age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            age--;

        return age;
    }

    public abstract decimal CalculateSalary();
}