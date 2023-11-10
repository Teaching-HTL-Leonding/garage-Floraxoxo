using Parking.Logic;
Console.Clear();

int choice;
decimal costs = 0;
int number = 0;
Garage myGarage = new Garage();
do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1) Enter a car entry");
    Console.WriteLine("2) Enter a car exit");
    Console.WriteLine("3) Generate report");
    Console.WriteLine("4) Exit");

    Console.Write("Your selection: ");
    choice = int.Parse(Console.ReadLine()!);
    switch(choice)
    {
        case 1:
            Eingabe(ref number);
            Console.Write("License Plate: ");
            string licensePlate = Console.ReadLine()!;
            Console.Write("Entry Date/Time: ");
            DateTime dt = DateTime.Parse(Console.ReadLine()!);
            myGarage.TryOccupy(number, licensePlate, dt);
            break;
        case 2:
            Eingabe(ref number);
            Console.Write("Parking Spot Number: ");
            number = int.Parse(Console.ReadLine()!);
            Console.Write("Exit Date/Time: ");
            dt = DateTime.Parse(Console.ReadLine()!);
            myGarage.TryExit(number, dt, ref costs);
            break;
        case 3:
            myGarage.GenerateReport();
            break;
    }
}while(choice != 4);

void Eingabe(ref int number)
{
    Console.Write("Parking Spot Number: ");
    number = int.Parse(Console.ReadLine()!) - 1;
}



