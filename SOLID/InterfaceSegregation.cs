using System;

public interface IPrinter
{
    public void Print();
}

public interface IScanner
{
    public void Scan(); 
}

// Here we have a normal printer with no scanner
public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }
}

// Here we have a two in one printer. A scanner and a printer in one.
public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}

/*
 * Here we are showcasing the Interface Segregation Principle, 
 * where the Printer class only takes on the IPrinter interface since it only needs to print
 * while the multi function printer, which also has a built in scanner,
 * takes on both interfaces, as we need both methods.
 */