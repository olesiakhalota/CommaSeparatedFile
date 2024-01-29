using CommaSeparatedFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Test.txt";
            string filePath = Path.Combine(projectDirectory, fileName);

            List<Person> people = new List<Person>();
            List<String> lines = File.ReadAllLines(filePath).ToList();


            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Person person = new Person();
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.Adress = entries[2];
                people.Add(person);
            }
            

            foreach (var item in people)
            {
                lstList.Items.Add(people);
            }

        }



        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Test.txt";
            string filePath = Path.Combine(projectDirectory, fileName);

            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = txtName.Text, LastName = txtSurname.Text, Adress = txtAdress.Text });
            

            List<String> output = new List<String>(); 
            foreach (Person person in people)
            {
                output.Add($"{person.FirstName.Trim() + ","} {person.LastName.Trim() + ","} {person.Adress.Trim() + ","}");
            }
            File.WriteAllLines(filePath, output);

        }
    }
}
