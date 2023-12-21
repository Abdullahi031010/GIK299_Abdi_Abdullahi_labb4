using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Abdi_Abdullahi_labb4
{
    class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Hair Hairinformation { get; set; }
        public string Eyecolor { get; set; }
        public Person(string name, Gender gender, DateTime birthday, Hair hairinformation, string eyecolor)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Hairinformation= hairinformation;
            Eyecolor = eyecolor;
            
        }
        public override string ToString()
        {
            return 
            $"Namn:{Name}\n" +
            $"Kön:{Gender}\n" +
            $"Födelsedatum:{Birthday:yyyy-MM-dd}\n" +
            $"Hårlängd:{Hairinformation.Length}\n" +
            $"Hårfärg:{Hairinformation.Color}\n" +
            $"Ögonfärg:{Eyecolor}\n";


        }




    }
}
