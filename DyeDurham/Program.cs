using DyeDurham;

var inputFile = "./unsorted-names-list.txt";
if(args!=null && args.Any())
{
    inputFile = args[0];
}

// Parse input file
var persons = Helper.ParseInputFile(inputFile);

// Sort list
persons = Helper.GetSortedPersonList(persons);

// Generate sorted output file
Helper.GenerateOutputFile(persons,true);

// Output sorted names list to screen
Helper.OutputToScreen(persons);

