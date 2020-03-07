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
        // used to return now redundant (complex) type GetCourses_Result, but modified to return Course entities
        // check the notes for an awesome way to create your own custom compelx type
        var courses = ctx.GetCourses();
        foreach (var course in courses)
        {
          var level = course.Level;
          Console.WriteLine($"{course.Title} - {level}");
        }
      }
      Console.WriteLine();
      Console.WriteLine("Process complete...");
      Console.ReadLine();
    }
  }
}
