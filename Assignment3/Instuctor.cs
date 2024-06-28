namespace Assignment3;

public class Instructor : Person
{
    public DateTime JoinDate { get; set; }

    public decimal CalculateBonusSalary()
    {
        var yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        return Salary + (yearsOfExperience * 1000);
    }

    public override decimal CalculateSalary()
    {
        return CalculateBonusSalary();
    }
}