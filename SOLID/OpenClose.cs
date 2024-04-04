using System;

/*
 * Abstract class, representing a geometric shape.
 * This shows the "open" principle, allowing subclasses to extend using this class.
 * This class is also shows the closed principle, meaning existing "shapes" dont need to be modified when other shapes are added.
 */
public abstract class Shape
{
    // This method is declared as abstract to enforce implementation by subclasses
    public abstract double Area();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        this._radius = radius; 
    }
    // Area method specific to a circle
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }
    // Area method specific to a rectangle
    public override double Area()
    {
        return _width * _height;
    }
}