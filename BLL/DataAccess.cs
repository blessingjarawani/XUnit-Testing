using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace BLL
{
    public static class DataAccess
    {
        private static string personelFile = "Personel.txt";

        public static void AddPerson(Person person)
        {

            var persons = GetPersons();
            AddPersonToList(persons, person);
            var personLines = GenerateCSV(persons);
            File.WriteAllLines(personelFile, personLines);
        }

        private static List<string> GenerateCSV(List<Person> persons)
        {
            List<string> lines = new List<string>();
            foreach (var personItem in persons)
            {
                lines.Add($"{personItem.FirstName}, {personItem.LastName}");
            }
            return lines;
        }

        public static void AddPersonToList(List<Person> people, Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
                throw new ArgumentException("Invalid FirstName", "FirstName");
            if (string.IsNullOrWhiteSpace(person.LastName))
                throw new ArgumentException("Invalid FirstName", "LastName");
            people.Add(person);
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
