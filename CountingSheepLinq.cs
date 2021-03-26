using System;
using System.Linq;

public static class Kata
{
  // returns the number of sheep (values that are true) in the array utilizing LINQ
  public static int CountSheeps(bool[] sheeps)
  {
    //TODO
    return sheeps.Count(sheep => sheep);
  }
}
