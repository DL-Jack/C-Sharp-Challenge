using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingChallenge.Repositories
{
    public class CodingChallengeRepository : ICodingChallengeRepository
    {
        // This is meant to mock a database table
        public List<Person> People = new List<Person>();

        public List<Person> GetPeople()
        {
            return People;
        }

        public void PopulatePersons()
        {
            People = new List<Person>();
            var personA = new Person 
            {
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(1966, 11, 22),
            };

            var personB = new Person
            {
                FirstName = "Jessica",
                LastName = "Johnson",
                DateOfBirth = new DateTime(1986, 03, 11),
            };

            var personC = new Person
            {
                FirstName = "Jose",
                LastName = "Valdes",
                DateOfBirth = new DateTime(2001, 01, 08),
            };

            People.Add(personA);
            People.Add(personB);
            People.Add(personC);
        }
    }
}
