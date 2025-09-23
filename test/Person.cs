class Person
{
    private readonly string DNI;
    private string name;
    private int age;
    private double height;
    private bool isEmployed;

    public Person(string dni, string name, int age, double height, bool isEmployed)
    {
        this.DNI = dni;
        this.name = name;
        this.age = age;
        this.height = height;
        this.isEmployed = isEmployed;
    }

    // Getters
    public string GetDNI()
    {
        return DNI;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public double GetHeight()
    {
        return height;
    }
    public bool IsEmployed()
    {
        return isEmployed;
    }

    // Setters
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public void SetHeight(double height)
    {
        this.height = height;
    }
    public void GiveEmployment()
    {
        isEmployed = true;
    }
    public void RemoveEmployment()
    {
        isEmployed = false;
    }


    // Tostring
    public override string ToString()
    {
        return $"DNI: {this.DNI}, Name: {this.name}, Age: {this.age}, Height: {this.height}m, Employed: {this.isEmployed}";
    }


}