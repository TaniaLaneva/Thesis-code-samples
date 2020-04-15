using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples.CleanCodeApproach
{
  public class Vector
  {
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Vector(Point3D point)
    {
      X = point.X;
      Y = point.Y;
      Z = point.Z;
    }

    public bool IsParallelToVector(Vector vector)
    {
      if (!AreZeroValuesMatchingForVector(vector)) return false;
      var listOfCoefficients = GetComponentsCoefficients(ConvertToList(this),
        ConvertToList(vector));
      return listOfCoefficients.Distinct().ToList().Count == 1;
    }

    private bool AreZeroValuesMatchingForVector(Vector vector)
    {
      if (!AreZeroValuesMatching(vector.X, X)) return false;
      if (!AreZeroValuesMatching(vector.Y, Y)) return false;
      if (!AreZeroValuesMatching(vector.Z, Z)) return false;

      return true;
    }

    private bool AreZeroValuesMatching(double a, double b)
    {
      if (IsEqualToZero(a) && !IsEqualToZero(b)) return false;
      if (!IsEqualToZero(a) && IsEqualToZero(b)) return false;
      return true;
    }

    private IEnumerable<double> GetComponentsCoefficients(IReadOnlyList<double> numeratorValues,
      IReadOnlyList<double> denominatorValues)
    {
      for (var i = 0; i < Math.Min(numeratorValues.Count, denominatorValues.Count); i++)
      {
        if (IsEqualToZero(denominatorValues[i])) continue;
        yield return numeratorValues[i] / denominatorValues[i];
      }
    }

    private List<double> ConvertToList(Vector vector)
    {
      return new List<double> {vector.X, vector.Y, vector.Z};
    }

    private bool IsEqualToZero(double value)
    {
      return value - 0 < 0.001;
    }
  }
}