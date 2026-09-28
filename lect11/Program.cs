using lect11.Enums;
using lect11.Models;

namespace lect11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pacient pacient = new Pacient();

      

            Nurse nurse1 = new Nurse(1,"luka", 30, "123456789", "555-1234-324", 21900 , new string[] { "monday" , "tuesday", "wednesday" , "sunday"}, new DOCTOR_PROFESSION[] {DOCTOR_PROFESSION.SURJEON});

            Nurse nurse2 = new Nurse(2, "nika", 40, "987654321", "555-1234-938", 3000, new string[] { "monday", "tuesday",  "sunday" }, new DOCTOR_PROFESSION[] { DOCTOR_PROFESSION.PSHYCHOLOG});

            Nurse nurse3 = new Nurse(3, "mate", 22, "888999000", "555-1234-324", 5900, new string[] { "monday", "wednesday", "sunday" }, new DOCTOR_PROFESSION[] { DOCTOR_PROFESSION.NEUROLOGIST});

            Nurse nurse4 = new Nurse(4, "gabrieli", 35, "112236789", "555-123-543", 41900, new string[] {  "tuesday", "wednesday", "sunday" }, new DOCTOR_PROFESSION[] { DOCTOR_PROFESSION.GENERAL_DOCTOR});

            Nurse nurse5 = new Nurse(5, "andria", 29, "123443289", "555-123-876", 51900, new string[] { "monday", "tuesday", "wednesday" }, new DOCTOR_PROFESSION[] { DOCTOR_PROFESSION.DENTIST });


            string answer;

            do
            { 
            Console.Write("tell me your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("araswori asaki seiyvane. Age gaxda 0.");
                age = 0;
                
            }
                pacient.Age = age;
            Console.WriteLine("seiyvane saxelida gvari : ");
            string name = Console.ReadLine();
                pacient.Fullname = name;

            Console.WriteLine("seiyvane person id : ");
            string personId = Console.ReadLine();
                pacient.PersonId = personId;

            Console.WriteLine("seiyvane seni telefonis nomeri : ");
            string phoneNumber = Console.ReadLine();
                pacient.Phonenumber = phoneNumber;

            Console.WriteLine("enter your id : ");
            int id = int.Parse(Console.ReadLine());
            pacient.Id = id;

                Console.WriteLine("");
                pacient.pacientinfo();

                Console.WriteLine("ramis secvla xom ar ginda : yes/no");
                answer = Console.ReadLine();

               
            }
            while (answer == "yes");

            Console.WriteLine("ra gwirt caweret romelime aqedan (organo/stress/memoryloss/couthing/tooth)");
            string doctor = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();


            Random Random = new Random();

            bool isAvailable = Random.Next(0, 2) == 1;
            bool isAvailable2 = Random.Next(0, 2) == 1;
            bool isAvailable3 = Random.Next(0, 2) == 1;
            bool isAvailable4 = Random.Next(0, 2) == 1;
            bool isAvailable5 = Random.Next(0, 2) == 1;

            Room room1 = new Room("skalpel" , isAvailable, "surjeon");
            Room room2 = new Room("counseling chair", isAvailable2, "pshycolog");
            Room room3 = new Room("brain scanner", isAvailable3, "neurologist"); 
            Room room4 = new Room("general equipment", isAvailable4, "general doctor");
            Room room5 = new Room("dental chair", isAvailable5, "dentist");

            switch (doctor)
            {
                case "organo":
                    nurse1.GetNurse();
            Console.WriteLine();
            Console.WriteLine();

                    Console.WriteLine($"doctor advise : miigge tablete bi operaciamde opracia catardeba  | es aris seni otaxis agwera ( {room1.GetRoom()} ) | eqimi {nurse1.Fullname} ");
                    break;
                case "stress":
                    nurse2.GetNurse();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine($"doctor advise : ar ifiqro araferze am otaxsi modi es aris | otaxis sesaxeb : ( {room2.GetRoom()} ) modi uketesi mkurnalobistvis | eqimi {nurse2.Fullname}");
                    break;
                case "memoryloss":
                    nurse3.GetNurse();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine($"doctor advise : donth think abouut anything just get a break and come in room | about room : ( {room3.GetRoom()} ) | eqimi {nurse3.Fullname}");
                    break;
                case "couthing":
                    nurse4.GetNurse();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine($"doctor advise : ubralod bronxebia da wamali miige am otaxsi daginisnav | otaxis sesaxeb: ( {room4.GetRoom()} ) | eqimi {nurse4.Fullname}");
                    break;
                case "tooth":
                    nurse5.GetNurse();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine($"doctor advise : gamayucebels gagiketeb am otaxsi | otaxis sesaxeb : ( {room5.GetRoom()} ) | eqimi {nurse5.Fullname}");
                    break;

                default:
                    Console.WriteLine("invalid doctor type");
                    break;
            }
            Console.ReadKey();

        }
    }
}
