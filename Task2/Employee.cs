public class Employee
{
    private int id;
    private string firstName;
    private string lastName;
    private int salary;
    public Employee( int id, string firstName, string lastName, int salary )
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }
    public int GetID()
    {
        return id;
    }
    public string GetFirstName()
    {
        return firstName;
    }
    public string GetLastName()
    {
        return lastName;
    }
    public string GetName()
    {
        return $"{firstName} {lastName}";
    }
    public int GetSalary()
    {
        return salary;
    }
    public void SetSalary( int salary )
    {
        this.salary = salary;
    }
    public int GetAnnualSalary()
    {
        return salary * 12;
    }
    public int RaiseSalary( int percent )
    {
        salary = salary * (100 + percent) / 100;
        return salary;
    }
    public override string ToString()
    {
        return $"Employee[ id = {id}, name = {firstName} {lastName}, salary = {salary}";
    }
}