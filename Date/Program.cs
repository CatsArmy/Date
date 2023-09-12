using Dates;

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
//Main();
ChildProgram();
//MessageProgram();