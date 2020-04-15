using System;
using System.Runtime.CompilerServices;
using Samples.AdHocApproach;
using Samples.CleanCodeApproach;

namespace Samples
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      PrintAdHocResults();
      PrintCleanCodeResults();
    }

    private static void PrintAdHocResults()
    {
      var perimeter = new Perimeter();
      var display = perimeter.CalculatePerimeter(new Tuple<double, double, double>(1, 1, 1),
        new Tuple<double, double, double>(1, 1, 5), new Tuple<double, double, double>(1, 1, 3));
      if (display != null)
      {
        Console.WriteLine(display);
      }

      var point1 = new Point3D(1, 1, 1);
      var point2 = new Point3D(1, 1, 1);
      var point3 = new Point3D(3, 3, 3);
      Console.WriteLine($"{point1.Equals(point2)} and {point1.Equals(point3)}");
    }

    private static void PrintCleanCodeResults()
    {
      var perimeterCalculator = new TrianglePerimeterCalculator(new TriangleValidator());
      try
      {
        var result = perimeterCalculator.Calculate(new Point3D(1, 1, 1), new Point3D(1, 1, 1), new Point3D(3, 3, 3));
        Console.WriteLine(result);
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}
