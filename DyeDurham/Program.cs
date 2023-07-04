
using DyeDurham;

var inputFile = "unsorted-names-list.txt";
if(args!=null && args[0] != null)
{
    inputFile = args[0];
}

// Parse input file
var persons = Helper.ParseInputFile(inputFile);

// Sort by last name, first name
persons = persons.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

// Generate sorted output file
Helper.GenerateOutputFile(persons,true);

// Output sorted names list to screen
Helper.OutputToScreen(persons);

