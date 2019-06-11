using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
  public class Catalog : Entity
  {
    public string Source { get; set; }
    public string Destination { get; set; }

    public void MoveCatalog()
    {
      try
      {
        Directory.Move(Source, Destination);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
