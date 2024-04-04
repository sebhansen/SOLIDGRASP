using System;

public abstract class Bird
{
    // Abstract method for flying behavior
    public abstract void Fly();
}

/*
 * We have two classes which are implementations of "Bird".
 * Crow implements it as they can fly, while Penguin is throwing an exception,
 * showing that they cannot fly.
 * 
 * Here we show the Liskov Substitution Principle, as Crow and Penguin
 * are both substitutable for Bird, 
 * and their behavior do not violate any expectations of the original Bird class
 */

// Concrete subclass
public class Crow : Bird
{
    // Implementing Fly method, specific to Crow
    public override void Fly()
    {
        throw new NotImplementedException("No logic, so we just do this instead.");
    }
}

// Concrete subclass
public class Penguin : Bird
{
    // Implementing Fly method, specific to Penguin
    public override void Fly()
    {
        throw new InvalidOperationException("Penguins cannot fly");
    }
}
