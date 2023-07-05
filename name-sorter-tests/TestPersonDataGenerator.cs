using System.Collections;

namespace name_sorter_tests;

public class TestPersonDataGenerator
{
    

    public static IEnumerable<object[]> GetPersonFromDataGenerator()
    {
        yield return new object[]
        {
            new Person {FirstName = "Marin", LastName = "Alvarez"},
            new Person {FirstName = "Adonis Julius", LastName = "Archer"},
            new Person {FirstName = "Hunter Uriah Mathew", LastName = "Clarke"},
            new Person {FirstName = "Mikayla", LastName = "Lopez"}
        };

        yield return new object[]
        {
            new Person {FirstName = "Frankie Conner", LastName = "Ritter"},
            new Person {FirstName = "Vaughn", LastName = "Lewis"},
            new Person {FirstName = "Beau Tristan", LastName = "Bentley"},
            new Person {FirstName = "Leo", LastName = "Gardner"}
        };

    }

   
}
