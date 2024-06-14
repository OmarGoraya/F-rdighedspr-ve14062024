using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve14062024
{
    internal class Group
    {

        public List<Group> Groups = new List<Group>();
        public string Name { get; set; }

        // Age, Aldersgruppe (7-9 år, 9-11 år, 11-13 år)
        public int Age { get; set; }
        public int NumberOfParticipants { get; set; }
        public int Id { get; set; }

        public Group(string name, int age, int numberOfParticipants, int id) 
        {
            Name = name;
            Age = age;
            NumberOfParticipants = numberOfParticipants;
            Id = id;
        }

        public void PresentGroup() 
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Number of participants {NumberOfParticipants}, Id: {Id}");
        }
    }
    
}
