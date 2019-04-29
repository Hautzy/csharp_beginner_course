using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.sektion_08
{
    class _08_haustiere
    {
        public struct Pet
        {
            public string name;
            public string owner;
            public int age;
            public string type;
        }

        static string[] TYPES = new string[] { "Dog", "Cat", "Fish", "Hamster", "Bird" };
        
        public static void Run()
        {
            Pet[] pets = new Pet[2];
            int countOfPets = 0;
            int selection = 0;

            do
            {
                Console.Clear();
                PrintMenu();
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        pets = AddPet(pets, ref countOfPets);
                        Print(pets, countOfPets);
                        break;
                    case 2:
                        RemoveByName(pets, ref countOfPets);
                        Print(pets, countOfPets);
                        break;
                    case 3:
                        SortByAge(pets, countOfPets);
                        Print(pets, countOfPets);
                        break;
                    case 4:
                        SortByName(pets, countOfPets);
                        Print(pets, countOfPets);
                        break;
                    case 5:
                        Console.Write("Count of pets: {0}", countOfPets);
                        break;
                    case 6:
                        CountPerType(pets, countOfPets);
                        break;
                }
                Console.ReadLine();
            } while (selection >= 1 && selection <= 6);
            Console.WriteLine("stopped...");
            Console.ReadLine();
        }

        public static void CountPerType(Pet[] pets, int countOfPets)
        {
            int[] counts = new int[TYPES.Length];
            for (int i = 0; i < pets.Length; i++)
            {
                for (int j = 0; j < TYPES.Length; j++)
                {
                    if(TYPES[j] == pets[i].type)
                    {
                        counts[j]++;
                    }
                }
            }
            Console.WriteLine("{0, -10} {1, -5}", "types", "count");
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("{0, -10} {1, -5}", TYPES[i], counts[i]);
            }
        }

        public static void Print(Pet[] pets, int count)
        {
            Console.WriteLine("---------");
            Console.WriteLine("{0, -16} {1, -16} {2, -6} {3, -16}", "name", "owner", "age", "type");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0, -16} {1, -16} {2, -6} {3, -16}", pets[i].name, pets[i].owner, pets[i].age, pets[i].type);
            }
        }

        public static void RemoveByName(Pet[] pets, ref int count)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if(pets[i].name == name)
                {
                    for (int j = i + 1; j < count; j++)
                    {
                        pets[i] = pets[j];
                    }
                    count--;
                    break;
                }
            }
        }

        public static Pet[] AddPet(Pet[] pets, ref int count)
        {
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("owner: ");
            string owner = Console.ReadLine();
            Console.Write("age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            bool validType = false;
            string type;
            do
            {
                Console.Write("type: ");
                type = Console.ReadLine();

                for (int i = 0; i < TYPES.Length; i++)
                {
                    if (type == TYPES[i])
                    {
                        validType = true;
                    }
                }
                if (!validType)
                {
                    Console.WriteLine("Invalid type!");
                }
            } while (!validType);

            Pet pet = new Pet();
            pet.name = name;
            pet.owner = owner;
            pet.age = age;
            pet.type = type;

            if(count >= pets.Length)
            {
                Pet[] arr = new Pet[pets.Length * 2];
                for (int i = 0; i < pets.Length; i++)
                {
                    arr[i] = pets[i];
                }
                arr[count] = pet;
                count++;
                return arr;
            }
            pets[count] = pet;
            count++;
            return pets;
        }

        public static void SortByAge(Pet[] pets, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (pets[j].age > pets[j + 1].age)
                    {
                        Pet temp = pets[j];
                        pets[j] = pets[j + 1];
                        pets[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortByName(Pet[] pets, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (pets[j].name.CompareTo(pets[j + 1].name) > 0)
                    {
                        Pet temp = pets[j];
                        pets[j] = pets[j + 1];
                        pets[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1) add pet");
            Console.WriteLine("2) remove pet by name");
            Console.WriteLine("3) sort by age");
            Console.WriteLine("4) sort by name");
            Console.WriteLine("5) count of pets");
            Console.WriteLine("6) count per type");
            Console.Write("> ");
        }
    }
}
