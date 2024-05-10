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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.IsEnabled = true;
            timer.Tick += timersay;
            DateTime dt = DateTime.Now;
            Date.Content = dt.ToLongDateString();
        }

        private void timersay(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            time.Content = simdi.ToLongTimeString();
        }

        private void cl1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            day.Content = turkce(cl1.SelectedDate.Value.DayOfWeek.ToString()) + "  " + cl1.SelectedDate.Value.Day.ToString();
            if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Saturday" || cl1.SelectedDate.Value.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Randevu alınamaz");
            }
        
        }
        private string turkce(string tr)
        { 
            string gun="" ;

            if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Monday")
            {
                tr = "Pazartesi";
            }

            else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Tuesday")
            {
                tr = "Salı";
            }

            else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Wednesday")
            {
                tr = "Çarşamba";
            }

            else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Thursday")
            {
                tr = "Perşembe";
            }

            else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Friday")
            {
                tr = "Cuma";
            }

          else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Saturday")
            {
                tr = "Cumartesi";
            }

            else if (cl1.SelectedDate.Value.DayOfWeek.ToString() == "Sunday")
            {
                tr = "Pazar";
            }
            else
            {
                gun = tr;
            }
            return tr;
        }
    
    }
}
