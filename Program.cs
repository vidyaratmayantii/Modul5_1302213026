using mod5_1302213026;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<int> simpleData = new SimpleDataBase<int>();
        simpleData.AddNewData(12);
        simpleData.AddNewData(34);
        simpleData.AddNewData(56);
    }
}