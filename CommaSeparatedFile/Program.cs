using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommaSeparatedFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"c:\demo\Test.txt"; //not goof nymore, it will be better to have this file in the map of the project in the bin map

            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;  //project map
            string fileName = "Test.txt";  //file
            string filePath = Path.Combine(projectDirectory, fileName); //file Test.txt was created in the map projectDirectory
            //Console.WriteLine(filePath);

            //Go to C:\Users\agatt\source\repos\CommaSeparatedFile\CommaSeparatedFile\bin\Debug
            //COPY file Test.txt from "Lessen" chanel and PUT file Test.txt there 

            //class Program created

            //READ FROM FILE

            List<Person> people = new List<Person>();  //people - LIST  VAN PERSON GEMAKT
            List<String> lines = File.ReadAllLines(filePath).ToList(); //lines - list van String. ReadAllLines from Test.txt and put to List lines  

            //read each line in lines
            foreach (string line in lines) 
            {
                string[] entries = line.Split(','); //eadere entries separated with comma AND each line has 3 entries
                Person person = new Person(); //obj person created 
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.Adress = entries[2]; //all stuff from the list lines is put into the object person  //light data van persone 
                people.Add(person); //add obj person into the people list
            }

            Console.WriteLine("Read from text file: ");
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Adress}" ); //showing in the console
            }
            //END  REAING THE FILE




            //forexample if you want to add 1-2 lines 
            //BEGIN WRITTING INTO FILE
            Console.WriteLine("Write to file: ");
            //2 persons created and put into list people
            people.Add(new Person { FirstName = "Olesia", LastName = "Khalota", Adress = "Olesia's adress" }); 
            people.Add(new Person { FirstName = "Rik", LastName = "Rizka", Adress = "Rik's adress" });

            //putting these 2 people into the list output
            List<String> output = new List<String>(); //list van string 
            foreach (Person person in people)
            {
                output.Add($"{person.FirstName.Trim() + ","} {person.LastName.Trim() + ","} {person.Adress.Trim() + ","}"); 
            }

            //putting list output into the file "Test.txt"
            File.WriteAllLines(filePath, output); 
            Console.WriteLine("Record(s) saved in the text file"); 
            Console.ReadLine();
            //Olesia and Rik is in the "Test.txt" 

            //trim spaces
            //ENT READING READING FILE


        }
    }
}
