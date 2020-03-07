using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var ctx = new PlutoDbContext())
      {
        var courses = ctx.GetCourses();
        foreach (var course in courses)
        {
          Console.WriteLine(course.Description);
        }
      }
      Console.WriteLine();
      Console.WriteLine("Process complete...");
      Console.ReadLine();
    }
  }
}
