using System;

namespace Samples.AdHocApproach
{
  //class to calculate perimeter of triangle
  public class Perimeter
  {
    public double? CalculatePerimeter(Tuple<double, double, double> point1, Tuple<double, double, double> point2,
      Tuple<double, double, double> point3)
    {
      //return null if triangle can not be built from these points.
      //check if point1 equal to point2
      if (Math.Abs(point1.Item1 - point2.Item1) < 0.001 &&
          Math.Abs(point1.Item2 - point2.Item2) < 0.001 &&
          Math.Abs(point1.Item3 - point2.Item3) < 0.001) return null;
      //check if point2 equal to point3
      if (Math.Abs(point2.Item1 - point3.Item1) < 0.001 &&
          Math.Abs(point2.Item2 - point3.Item2) < 0.001 &&
          Math.Abs(point2.Item3 - point3.Item3) < 0.001) return null;
      //check if point1 equal to point3
      if (Math.Abs(point1.Item1 - point3.Item1) < 0.001 &&
          Math.Abs(point1.Item2 - point3.Item2) < 0.001 &&
          Math.Abs(point1.Item3 - point3.Item3) < 0.001) return null;

      //build vector AB and and AC
      var ab = new Tuple<double, double, double>(point2.Item1 - point1.Item1, point2.Item2 - point1.Item2,
        point2.Item3 - point1.Item3);
      var ac = new Tuple<double, double, double>(point3.Item1 - point1.Item1, point3.Item2 - point1.Item2,
        point3.Item3 - point1.Item3);

      /*check if vector AB parallel to vector AC. If AB parallel to AC, then points A, B and C will be
       collinear and triangle will be not possible to build. */
      var t1 = double.NaN;
      var t2 = double.NaN;
      var t3 = double.NaN;
      if (ac.Item1 - 0 > 0.001)
      {
        t1 = ab.Item1 / ac.Item1;
      }

      if (ac.Item2 - 0 > 0.001)
      {
        t2 = ab.Item2 / ac.Item2;
      }

      if (ac.Item3 - 0 > 0.001)
      {
        t3 = ab.Item3 / ac.Item3;
      }

      if (Math.Abs(t1 - t2) < 0.001 && Math.Abs(t1 - t3) < 0.001) return null;

      //calculate the distance between points and return their sum as the answer
      //calculate distance between point1 and point2
      var d1 = Math.Sqrt(Math.Pow(point2.Item1 - point1.Item1, 2) + Math.Pow(point2.Item2 - point1.Item2, 2) +
                         Math.Pow(point2.Item3 - point1.Item3, 2));
      //calculate distance between point2 and point3
      var d2 = Math.Sqrt(Math.Pow(point3.Item1 - point2.Item1, 2) + Math.Pow(point3.Item2 - point2.Item2, 2) +
                         Math.Pow(point3.Item3 - point2.Item3, 2));
      //calculate distance between point 3 and point 1
      var d3 = Math.Sqrt(Math.Pow(point1.Item1 - point3.Item1, 2) + Math.Pow(point1.Item2 - point3.Item2, 2) +
                         Math.Pow(point1.Item3 - point3.Item3, 2));

      return d1 + d2 + d3;
    }
  }
}