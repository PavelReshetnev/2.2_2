namespace ConsoleApp7;

public class Train
{
    public int trainNum;
    public string point;
    public string departTime;
    public Train(int trainNum, string point, string departTime) {
        this.trainNum = trainNum;
        this.point = point;
        this.departTime = departTime;
    }
    public int GetNumber { 
        get{
            return trainNum;
        }
    }

    public string traininfo()
    {
        return ("Номер :" + trainNum + "; След.Остановка: " + point + "; Время отправленипя: " + departTime);
    }
}