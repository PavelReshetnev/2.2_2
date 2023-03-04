namespace ConsoleApp7;

public class Program
{
    static void Main(string[] args)
    {
        List<Train> trains = new List<Train>(); 
        trains.Add(new Train(69, "Tomsk", "16:25")); 
        trains.Add(new Train(23, "Tomsk", "8:00")); 
        
        int vizov = Convert.ToInt32(Console.ReadLine()); 
        string otvet = ""; 
        foreach (Train schitala in trains) { 
            if (schitala.GetNumber == vizov){
                otvet = schitala.traininfo();
                break;
            }
        }

        if (otvet != ""){
            Console.WriteLine(otvet);
        } else {
            Console.WriteLine("Такого поезда не существует"); 
        }
    }
}