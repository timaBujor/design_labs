Console.WriteLine("Hello, Jerry");
PrintText();
PrintText();
PrintText();

void PrintText()
{
    Console.WriteLine("A");
    Thread.Sleep(500);
    Console.WriteLine("B");
    Thread.Sleep(500);
    Console.WriteLine("C");
    Thread.Sleep(500);
    PrintName();
    PrintLastName();
}

void PrintName()
{
    Console.WriteLine("Tim");
}

void PrintLastName()
{
    Console.WriteLine("Bujor");
}