
using Egzas1017;
using System.Security.Cryptography.X509Certificates;
var dateTime = DateTime.Now.ToString();
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Please enter clients' name");
    string clientName = Console.ReadLine();
    Console.WriteLine("Please chose product type: either FW, INS or IMPUB");
    string prodTypeChosen = Console.ReadLine();

    if (prodTypeChosen == "FW")
    {
        Console.WriteLine("Please chose FW model");
        string fwModelChosen = Console.ReadLine();
        FWModelRepository fWModelRepository = new FWModelRepository();


    }
    else if (prodTypeChosen == "INS")
    {
        Console.WriteLine("Please chose INS lenght: full or 3/4");
        string insLenghtChosen = Console.ReadLine();
        InsModelRepository insModelRepository = new InsModelRepository();

        //Material1 material1 = new Material1();

        Console.WriteLine($"{insModelRepository.insModels}");

    }
    else
    {
        Console.WriteLine("Please chose FW model");
        string fwModelChosen = Console.ReadLine();
        FWModelRepository fWModelRepository = new FWModelRepository();

        Console.WriteLine("Please chose INS lenght: full or 3/4");
        string insLenghtChosen = Console.ReadLine();
    }
    OrderCalculator orderCalc = new OrderCalculator();

    OrderList orderList = new OrderList();
    
}


