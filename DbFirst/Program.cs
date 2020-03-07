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
        // used to return now redundant type GetCourses_Result, but modified to return Course entities
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
