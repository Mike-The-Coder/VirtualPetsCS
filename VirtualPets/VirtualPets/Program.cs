// See https://aka.ms/new-console-template for more information

using VirtualPets;

List<PetClass> PetList = new List<PetClass>();

Random rnd = new Random(); //need to randomize better, new value everytime. nevermind, did it
int num = rnd.Next(1, 10);



PetList.Add(new PetClass("Pet", rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)));
PetList.Add(new PetClass("Pat", rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)));
PetList.Add(new PetClass("Pit", rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)));



Console.WriteLine("Welcome to Virtual Pet in C#!");
Console.WriteLine($"You get a free pet! The name is ...");

StatLister(PetList);

do
{
    Console.WriteLine(
        "1. Feed the pets \n" +
        "2. Water the pets \n" +
        "3. Play with the pets\n" +
        "4. See stats\n" +
        "5. Feed one\n" +
        "6. Play with one\n" +
        "7. Water one\n" +
        "8. Adopt a pet\n" +
        "9. Rehome a pet\n" +
        "0. ???\n");


    var userinput = Console.ReadLine();

    switch (userinput)
    {
        case "1":
           foreach (PetClass pet in PetList)
            {
                pet.feedAll();
                pet.stats();
                pet.timeIncrement();
            }
            break;
        case "2":
            foreach (PetClass pet in PetList)
            {
                pet.waterAll();
                pet.stats();
                pet.timeIncrement();

            }
            break;
        case "3":
            foreach (PetClass pet in PetList)
            {
                pet.playAll();
                pet.stats();
                pet.timeIncrement();

            }
            break;

        case "5":
            Console.WriteLine("Choose a pet to feed alone");
            StatLister(PetList);
            var petNumber = Console.ReadLine();
            PetList[Convert.ToInt32(petNumber)-1].feedOne();
            foreach (PetClass pet in PetList)
            {
                pet.stats();
                pet.timeIncrement();
            }
            break;
        case "6":
            Console.WriteLine("Who do you want to play with?");
            StatLister(PetList);
            var petNumber2 = Console.ReadLine();
            PetList[Convert.ToInt32(petNumber2)-1].playOne();
            foreach (PetClass pet in PetList)
            {
                pet.stats();
                pet.timeIncrement();
            }
            break;
        case "7":
            Console.WriteLine("Who do you want to water?");
            StatLister(PetList);
            var petNumber3 = Console.ReadLine();
            PetList[Convert.ToInt32(petNumber3)-1].waterOne();
            foreach (PetClass pet in PetList)
            {
                pet.stats();
                pet.timeIncrement();
            }
            break;
        case "8":
            string petName;
            Console.WriteLine("What is your new pet's name?");
            petName = Console.ReadLine();
            PetList.Add(new PetClass(petName, rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)));
            foreach (PetClass pet in PetList)
            {
                pet.stats();
                pet.timeIncrement();
            }
            break;
        case "9":
            Console.WriteLine("Who do you want to send to the farm?");
            var inty = "0";
            inty = Console.ReadLine();
            PetList.RemoveAt(Convert.ToInt32(inty)-1);
            break;
        case "0":
            break;
        default:

            
            break;
    }
} while (true);

static void StatLister(List<PetClass> PetList)
{
    for (int i = 0; i < PetList.Count; i++)
    {
        Console.Write((i + 1) + ". ");
        PetList[i].stats();
    }
}