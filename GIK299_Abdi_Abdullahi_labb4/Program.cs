using System.ComponentModel.Design;
using System.Drawing;

namespace GIK299_Abdi_Abdullahi_labb4
{
    class Program
    {
        static void Main()
        {
            //skapa en tom lista för att lagra personobjekt.

            List<Person> peoplelist = new List<Person>();
            bool continueProgram = true;

            // Huvudmeny för programmet.
            while (continueProgram)
            {
                Console.WriteLine("\nVälj en alternativ:");
                Console.WriteLine("1. Lägg till person");
                Console.WriteLine("2. Lägg en lista medd alla personer tillladga");
                Console.WriteLine("3. Avsluta Programmet");

                // Kontrollera att användarens inmatning är ett giltigt heltal.
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {

                    Console.WriteLine("Fel inmatning. Ange ett nummer bland tre valen");
                    continue;
                }
                // Hantera användarens val.
                switch (choice)
                {
                    case 1:
                        AddPerson(peoplelist);
                        break;

                    case 2:
                        ListPerson(peoplelist);
                        break;
                    case 3:
                        continueProgram = false;
                        break;


                    default:
                        Console.WriteLine("Fel val. Välj ett giltigt alternativ");
                        break;



                }


            }
        }
    
        static void AddPerson(List<Person> list) 
        {
            Console.WriteLine("Lägg till en person");

            // Variabler för att lagra personens information.
            string name;
            Gender gender;
            DateTime birthday;
            int hairLenght;
            string haircolor, eyeColor;

            // Fråga användaren om personens namn och läs in det.
            Console.WriteLine("Vad heter personen");
            name = Console.ReadLine();

            // Loop för att hantera inmatning av kön.
            do
            {
                Console.WriteLine("Ange Kön på personen ( Man, Kvinna, Annat):");
                string personGender = Console.ReadLine();

                if (personGender == "Man" || personGender.ToLower () == "Man") 
                {
                    gender = Gender.Man;
                    break;
                }
                else if (personGender == "Kvinna" || personGender.ToLower() == "Avinna")
                {
                    gender = Gender.Kvinna;
                    break;
                }
                else if (personGender == "Annat" || personGender.ToLower() == "Annat")
                {
                    gender = Gender.Annat;
                    break;
                }

                else 
                {
                    Console.WriteLine("Fel inmatning, välj mellan Man, Kvinna, Annat ");
                }

            }while(true);

            // Loop för att hantera inmatning av födelsedatum.
            while (true) 
                {
                    Console.Write("Ange personens födelsedatum yyyy-MM-dd: ");
                    if  (DateTime.TryParse(Console.ReadLine(), out birthday))
                        {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt datumformat. Ange  datum i yyyy-MM-dd");
                    }
                   
                }
            // Loop för att hantera inmatning av hårlängd.
            while (true)
                {   
                    Console.Write("Ange personens hårlängd i cm ");
                    if (int.TryParse(Console.ReadLine(), out hairLenght))

                    {
                        break;
                    }
                    
                       else
                        { Console.WriteLine("ogiltig hårlängd. Ange ett nummer ");

                        }

                
                }

            Console.Write("Ange personens hårfärg ");
            haircolor = Console.ReadLine();

            Console.Write("ange personens ögonfärg ");
            eyeColor = Console.ReadLine();

            Hair hairinformation = new Hair { Length = hairLenght, Color = haircolor, Eyecolor = eyeColor };
            Person newperson = new Person(name, gender, birthday, hairinformation, eyeColor);

            list.Add(newperson);
            Console.WriteLine("Person tillagd");





        }
        // Metod för att lista alla tillagda personer.

        static void ListPerson(List<Person> list)
            {
            // Kontrollera om listan är tom.
            if ( list.Count==0)
                {
                    Console.WriteLine("Det finns inga personer i listan");

                }
                else
                {
                    Console.WriteLine("Listan med tillagda personer");

                // Loopa igenom varje person i listan och skriv ut deras information.
                foreach (var person in list)
                    
                    { 
                        Console.WriteLine(person.ToString());
                    }
                }
            }


    }
}