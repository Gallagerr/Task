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
      lblTime.Content = DateTime.Now.ToLongTimeString();
    }

    private void Save_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {

    }

    private void MovieCatalog_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {

    }

    private void SendMail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {

    }
  }
}
