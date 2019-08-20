using System;

public class Text
{
    public void MyPrinter(string _val)
    {
        Console.WriteLine(_val);

    }

    public string Ask(string _val)
    {
        Console.Write(_val);
        return Console.ReadLine();
    }
}
