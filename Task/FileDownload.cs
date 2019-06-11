using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
  public class FileDownload : Entity
  {
    public string Address { get; set; }
    public string Path { get; set; }
    public void DownloadFile()
    {
      using (var webClient = new WebClient())
      {
        webClient.DownloadFile(Address, Path);
      }
    }
  }
}
