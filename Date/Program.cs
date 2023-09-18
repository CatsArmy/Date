using Dates;
using Dates.Complex_Classes_1;
using System.Net.Http.Headers;

void DateProgram()
{
    Date date = new Date(19, 9, 1981);
    Date date1 = date;
    date.SetDay(20);
    date1.SetYear(1983);
    Console.WriteLine($"{date}\n{date1}");
    Date date2 = new Date();
    Console.WriteLine(date2);
    Date date3 = new Date(20, 6, 2016);
    Date date4 = date3;
    date3.SetDay(1);
    date4.SetMonth(9);
    date4 = new Date(date3);
    Console.WriteLine(date4);
    Date date5 = new Date(15, 3, 2012);
    Console.WriteLine($"{date5}: {(date5.IsLeapYear() ? "Is" : "Isnt")} a leap year");
    Date date6 = new Date(20, 6, 2016);
    Date date7 = new Date(21, 6, 2016);
    Date date8 = new Date(date6);
    Console.WriteLine(date6.Compare(date7));
    Console.WriteLine(date7.Compare(date6));
    Console.WriteLine(date8.Compare(date6));
}
void ChildProgram()
{
    Child c1 = new Child("Judith", "111", 'F', new Date(15, 9, 2005));
    Child c2 = new Child("Nurith", "222", 'F', new Date(10, 12, 2004));
    Child c3 = new Child("Hava", "333", 'F', new Date(14, 5, 2005));
    if (c1.SameBirthDay(c2))
        Console.WriteLine("Same Day! ");
    else
        Console.WriteLine("Not Same Day");
}
void MessageProgram()
{
    Date date = new Date(25, 3, 2021);
    Message message = new Message("Gidi", "Meir", "Hi! How are you?", date);
    Console.WriteLine(message);
    date.SetDay(28);
    message.Forword("Yoni", date);
    Console.WriteLine(message);
    date.SetDay(30);
    message.Reply("I'm Fine, Thanks", date);
    Console.WriteLine(message);
}
void Main()
{
    Child gidi = new Child("Gidi", "1345", 'M', new Date(2, 8, 2005));
    Child meir = new Child("Meir", "3425", 'M', new Date(6, 9, 2016));
    Child yoni = new Child("Yoni", "2345", 'M', new Date(5, 15, 2016));
    Date date = new Date(2, 8, 2023);
    Console.WriteLine(date);
    Message message = new Message(yoni.GetName(), meir.GetName(), "Happy birthday Meir", date);
    Console.WriteLine(message);
    message.Reply("Thank you Yoni", date);
    Console.WriteLine(message);
    date = new Date(2, 9, 2023);
    message.Forword(gidi.GetName(), date);
    Console.WriteLine(message);
    Date date2 = new Date(2, 10, 2023);
    Console.WriteLine(date2);
    Message message2 = new Message(gidi.GetName(), yoni.GetName(),
        "Oh no did i forget Meir's Birthday?", date2);
    Console.WriteLine(message2);
    message2.Forword(meir.GetName(), date);
    Console.WriteLine(message2);
    Console.WriteLine("\nThe timeline makes no sence ignore it...");
}
void TravelerProgram()
{
    Traveler travler = new Traveler(new Passport("person1", 1, new Date(1, 1, 2009)), true);
    Traveler travler1 = new Traveler(new Passport("person2", 2, new Date(1, 1, 2007)), true);
    Traveler travler2 = new Traveler(new Passport("person3", 3, new Date(1, 2, 2008)), false);
    if (travler.CheckTravel(new Date(1, 1, 2008)))
        Console.WriteLine(travler);
    if (travler1.CheckTravel(new Date(1, 1, 2008)))
        Console.WriteLine(travler1);
    if (travler2.CheckTravel(new Date(1, 1, 2008)))
        Console.WriteLine(travler2);
    Console.WriteLine("After paying t2 is?");
    travler2.Pay();
    if (travler2.CheckTravel(new Date(1, 1, 2008)))
        Console.WriteLine(travler2);

}
void ProgramAB()
{
    A a = new A(10);
    B b = new B(a);
    a.SetX(7);
    A a1 = b.GetA();
    a1.SetX(13);
    Console.WriteLine(a);
    Console.WriteLine(a1);
    Console.WriteLine(b);
    //The issue with sharing memory is that you can change stuff you dont expect to be changed and then get errors and unexpected results
    //its best to just use the copy CTOR if you can.
}
//Main();
//ChildProgram();
//MessageProgram();
//DateProgram();
//TravelerProgram();
