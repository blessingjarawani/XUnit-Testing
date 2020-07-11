using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace BLL
{
    public static class DataAccess
    {
        private static string personelFile = "Personel.txt";

        public static void AddPerson(Person person)
        {
            var personLines = new List<string>();
            var persons = GetPersons();
            persons.Add(person);

            foreach (var personItem in persons)
            {
                personLines.Add($"{personItem.FirstName}, {personItem.LastName}");
            }
            File.WriteAllLines(personelFile, personLines);
        }

        private static List<Person> GetPersons()
        {
            var output = new List<Person>();
            var content = File.ReadAllLines(personelFile);
            foreach (var line in content)
            {
                var buffer = line.Split(',');
                output.Add(new Person { FirstName = buffer[0], LastName = buffer[1] });
            }
            return output;
        }
    }
}
