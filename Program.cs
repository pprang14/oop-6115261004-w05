using System;

namespace oop_6115261004_w05
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b4 = new Building("433", "skytown", "126", "256");
            Room r433 = new Room("433", "Room 433", "4", "4", "computer", b4);
            Subject s061 = new Subject("061", "ced61", "500", "12", "12");
            Lecturer chirapat = new Lecturer("chirapat", "phlchan", "lecturer");
            Section G1 = new Section("01/06/2563", "8.00", "12.00", r433, s061, chirapat);
            Console.WriteLine(b4.ToString());
            Console.WriteLine(r433.ToString());
            Console.WriteLine(s061.ToString());
            Console.WriteLine(chirapat.ToString());
            Console.WriteLine(G1.ToString());
        }
    }
}
