using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
using System.IO;

namespace Task
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      DispatcherTimer timer = new DispatcherTimer();
      timer.Interval = TimeSpan.FromSeconds(1);
      timer.Tick += timer_Tick;
      timer.Start();
    }
    void timer_Tick(object sender, EventArgs e)
    {
      lblTimeDownload.Content = DateTime.Now.ToLongTimeString();
      lblTimeCatalog.Content = DateTime.Now.ToLongTimeString();
      lblTimeEmail.Content = DateTime.Now.ToLongTimeString();
    }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
      SaveGrid.Visibility = Visibility.Visible;
    }

    private void MovieCatalog_Click(object sender, RoutedEventArgs e)
    {
      CatalogGrid.Visibility = Visibility.Visible;

      //FromCatalog sourceDirectory;
      //ToCatalog targetDirectory;
    //  Copy(sourceDirectory, targetDirectory);
    }

    private void SendMail_Click(object sender, RoutedEventArgs e)
    {
      EmailGrid.Visibility = Visibility.Visible;
    }

    public static void Copy(string sourceDirectory, string targetDirectory)
    {
      DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
      DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

      CopyAll(diSource, diTarget);
    }
    public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
    {
      // Если директория target.FullName не существует, создать ее
      if (!Directory.Exists(target.FullName))
      {
        Directory.CreateDirectory(target.FullName);
      }
      // Копируем файлы из sourceDirectory в targetDirectory
      foreach (FileInfo fi in source.GetFiles())
      {
        fi.CopyTo(System.IO.Path.Combine(target.ToString(), fi.Name), true);
      }
      // Копируем поддиректории
      foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
      {
        DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
        CopyAll(diSourceSubDir, nextTargetSubDir);
      }
    }

  }
}
