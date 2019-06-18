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
  }
}
