
public class Person
{
    public Person()
    {
        FirstName = "";
        LastName = "";
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }

    public string ToLineString()
    {
        return FirstName + " " + LastName + Environment.NewLine;
    }
}

