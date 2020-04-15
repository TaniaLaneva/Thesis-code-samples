using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples;

namespace UnitTests
{
  [TestClass]
  public class SamplesTest
  {
    [TestMethod]
    public void Check_Sum_Of_2_numbers_correct()
    {
      var codeSample = new CleanCodeSample();
      Assert.AreEqual(2, codeSample.Sum(1,1));
    }
  }
}
