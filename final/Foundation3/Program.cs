using System;

class Program
{
    static void Main(string[] args)
    {
        Events e1 = new Events("Events",     "This will be a lecture Event",   24/10/23  ,  11.00);
        Console.WriteLine(e1.GetSummmary());

        LecturesEvent L1 = new LecturesEvent("History",    "This will be a lecture on History", 23/10/23, 11,  "Malcolm Nkomo",    230);
        Console.WriteLine(L1.GetSummmary());
        Console.WriteLine(L1.GetLectureInformation());


        ReceptionsEvent r1 = new ReceptionsEvent("Receptions",   "A reception for Mr Ndlovu and Mrs Ndlovu", 11/12/22, 12,    "ndlovu@gmail.com");
        Console.WriteLine(r1.GetSummmary());
        Console.WriteLine(r1.GetReceptionInformation());

        OutdoorGatheringsEvents o1 = new OutdoorGatheringsEvents("Shade",   "A seminar in the shade",   4/11/23, 7,   "It is windy today");
        Console.WriteLine(o1.GetSummmary());
        Console.WriteLine(o1.GetWeatherInformation());

        Address a1 = new Address("Farmington",    "Bulawayo");
        Console.WriteLine(a1.GetAddress());


        
    }
}