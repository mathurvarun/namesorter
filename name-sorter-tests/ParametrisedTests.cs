using DyeDurham;

namespace name_sorter_tests;

public class ParametrisedTests
{
    [Fact]
    public void IsSortedCorrectly()
    {
        var persons = new List<Person>();
       
        persons = Helper.GetSortedPersonList(persons);
        
        var alphabetical = !persons.Where((s, n) => n < persons.Count - 1 && StringComparer.Ordinal.Compare(persons[n].LastName, persons[n + 1].LastName) > 0).Any();
        Assert.True(alphabetical);
    }

    [Theory]
    [MemberData(nameof(TestPersonDataGenerator.GetPersonFromDataGenerator), MemberType = typeof(TestPersonDataGenerator))]
    public void AllPersons_AreSortedCorrectly_WithPersonData_FromDataGenerator(Person a, Person b, Person c, Person d)
    {
        
        
    }
}
