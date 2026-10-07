//   Task 10

// program must show menu, takes a circle radius from user repeatedly
// until they enter 0

// create method:    static double CircleArea(double radius)
//      takes radius input and returns area of circle
// method should use : area of circle = pi * radius * radius

static double CircleArea(double radius)
{
    // returns area of circle
    // area of circle = pi * radius * radius
    double areaOfCircle = Math.PI * Math.Pow(radius, 2);

    return areaOfCircle;
}           




Main();

static void Main()
{

    double radius = 1;

    while (radius != 0)
    {
        Console.WriteLine("Enter radius");
        radius = Convert.ToDouble((Console.ReadLine()));

        Double x = CircleArea(radius);
        Console.WriteLine($"The area of the circle is: {x}");
    }


}