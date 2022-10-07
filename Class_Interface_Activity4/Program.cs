//Class - have 1 interface with 3 of:
//instance method, properties, events, indexers
//also have 3 different type of properties


//Interface
interface ICar
{
    void CarFact();     //a interface method
    string CarSpec { get; set; }    //getter/setter properties
    string this[int i] { get; set; }
}


class Vehicle: ICar
{
    public void CarFact()
    {
        Console.WriteLine("The cars you're looking are all from 2020 or newer!");
    }

    private string spec = "";
    public string CarSpec
    {
        get { return spec; }
        set { spec = value; }
    }

    private string[] arr = new string[100];
    public string this[int i]   //indexer
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle my_vehicle = new Vehicle(); //create Vehicle object
        my_vehicle.CarFact();
        my_vehicle.CarSpec = "Minumum car horsepower on the lot is 473HP";
        Console.WriteLine(my_vehicle.CarSpec);
        Console.Write("What car would you like to order?\n");
        my_vehicle[0] = Console.ReadLine();
        Console.WriteLine(my_vehicle[0]);
    }
}