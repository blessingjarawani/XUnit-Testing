using BLL;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xunit;

namespace DemoTests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            var newPerson = new Person
            {
                FirstName = "Blessing",
                LastName = "Jarawani"
            };
            var people = new List<Person>();
            DataAccess.AddPersonToList(people, newPerson);
            Assert.True(people.Count == 1);
            Assert.Contains<Person>(newPerson, people);
        }

        [Theory]
        [InlineData("Blessing", "", "LastName")]
        [InlineData("", "Jarawani", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string LastName, string param)
        {
            var newPerson = new Person
            {
                FirstName = firstName,
                LastName = LastName
            };
            var people = new List<Person>();
            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToList(people, newPerson));
        }
    }
}
