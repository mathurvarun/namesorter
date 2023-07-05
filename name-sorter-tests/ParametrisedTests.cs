using DyeDurham;

namespace name_sorter_tests;

public class ParametrisedTests
{
   
    public static bool IsSortedCorrectly(Person a, Person b, Person c, Person d)
    {
        var persons = new List<Person>();
        persons.Add(a);
        persons.Add(b);
        persons.Add(c);
        persons.Add(d);
        persons = Helper.GetSortedPersonList(persons);
        
        var alphabetical = !persons.Where((s, n) => n < persons.Count - 1 && StringComparer.Ordinal.Compare(persons[n].LastName, persons[n + 1].LastName) > 0).Any();
        return alphabetical;
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetPersonFromDataGenerator), MemberType = typeof(TestDataGenerator))]
    public void AllPersons_AreSortedCorrectly_WithPersonData_FromDataGenerator(Person a, Person b, Person c, Person d)
    {
        Assert.True(IsSortedCorrectly(a,b,c,d));
        
    }
}
