namespace Laby26._02;
using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Kuba", "Zygmunt","123456789", 4.9f);
        Console.WriteLine(student.getImie());
        Console.WriteLine(student.getNazwisko());
        Console.WriteLine(student.getNrAlbumu());
        Console.WriteLine(student.getSrednia());
        Console.WriteLine(student.Stypendium());
    }
}
