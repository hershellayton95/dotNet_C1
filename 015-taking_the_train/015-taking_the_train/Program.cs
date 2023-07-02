/*
Create a console application that uses a LinkedList to represent a train route with various stations.
Add and remove stations, and display the route.
Can you make the train station into a class?
*/

using _015_taking_the_train.Model;

LinkedList<TrainStation> trainStations = new LinkedList<TrainStation>();


while (true)
{

    Console.WriteLine("Make a choise (1 - 2 - 3)");
    Console.WriteLine("1 - Add a train station");
    Console.WriteLine("2 - Remove a train station");
    Console.WriteLine("3 - Print a train station");
    Console.WriteLine("Press another key to end the program");
    Console.WriteLine();

    char inputChar = Console.ReadKey(true).KeyChar;
    TrainStation? trainStation = null;

    switch (inputChar)
    {
        case '1':
            Console.WriteLine("Make a choise (1 - 2 - 3)");
            Console.WriteLine("1 - Add in the first position");
            Console.WriteLine("2 - Add in the last position");
            Console.WriteLine();
            inputChar = Console.ReadKey(true).KeyChar;
            switch (inputChar)
            {
                case '1':

                    trainStation = MakeTrainStation();
                    trainStations.AddFirst(trainStation);
                    break;
                case '2':
                    trainStation = MakeTrainStation();
                    trainStations.AddLast(trainStation);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    continue;
            }
            Console.WriteLine($"{trainStation.Name} has been added");
            Console.WriteLine();
            break;
        case '2':
            if (trainStations.Count() <= 0)
            {
                Console.WriteLine("There isn't station to remove");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine("Make a choise (1 - 2 - 3)");
            Console.WriteLine("1 - Remove in the first position");
            Console.WriteLine("2 - Remove in the last position");
            Console.WriteLine("3 - Remove before nº");
            Console.WriteLine();
            inputChar = Console.ReadKey(true).KeyChar;
            switch (inputChar)
            {
                case '1':
                    trainStation = trainStations.First();
                    trainStations.RemoveFirst();
                    break;
                case '2':
                    trainStation = trainStations.Last();
                    trainStations.RemoveLast();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    continue;
            }
            Console.WriteLine($"{trainStation.Name} has been removed");
            Console.WriteLine();
            break;
        case '3':
            if (trainStations.Count() <= 0)
            {
                Console.WriteLine("There isn't station to print");
                Console.WriteLine();
                continue;
            }
            int i = 0;
            foreach (TrainStation item in trainStations)
            {
                i++;
                Console.WriteLine(i + "º - " + item.Name);
            }
            Console.WriteLine();
            break;
        default:
            Environment.Exit(0);
            break;
    }
}

TrainStation MakeTrainStation()
{
    Console.WriteLine("What's train station name?");
    string? input = Console.ReadLine();
    if (input == null || input == "")
    {
        throw new Exception();
    }

    TrainStation station = new TrainStation(input);
    return station;
}