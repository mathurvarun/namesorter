using System.Text;

namespace DyeDurham
{
    public class Helper
	{

        
        public static List<Person> ParseInputFile(string filePath)
        {
            var persons = new List<Person>();
            try
            {
                if (File.Exists(filePath))
                {
                    string[] fileContent = File.ReadAllLines(filePath);
                    foreach (var line in fileContent)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            var person = new Person();
                            person.LastName = line.Substring(line.LastIndexOf(' '), line.Length - line.LastIndexOf(' ')).Trim();
                            person.FirstName = line.Substring(0, line.LastIndexOf(' ')).Trim();
                            persons.Add(person);
                        }                        
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
                return persons;

            }
            catch (Exception exc)
            {
                Console.WriteLine("Unable to read file - " + exc.Message);
                return persons;
            }

        }

        // Generate Output File
        public static void GenerateOutputFile(List<Person> persons, bool overwriteExistingFile = false, string outputFileName = "")
        {
            var outputFile = "sorted-names-list.txt";
            if (!string.IsNullOrEmpty(outputFileName))
            {
                outputFile = outputFileName;
            }

            try
            {
                byte[] info = persons.SelectMany(x => Encoding.UTF8.GetBytes(x.ToLineString())).ToArray();

                if (!File.Exists(outputFile))
                {
                    WriteFile(outputFile, info);
                }
                else
                {
                    if (overwriteExistingFile)
                    {
                        File.WriteAllBytes(outputFile, info);
                    }
                    else
                    {
                        Console.WriteLine("File already exists");
                    }
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine("Unable to write file - " + exc.Message);
            }

        }

        // Output Person's object to screen
        public static void OutputToScreen(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

        // Create output file
        private static void WriteFile(string outputFile, byte[] info)
        {
            FileStream fs = File.Create(outputFile);
            {
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }

        public static List<Person> GetSortedPersonList(List<Person> persons)
        {
            return persons.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }
    }    
}

