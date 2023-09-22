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

namespace Scholar
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

        private void tbFinish_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            
            if((dpStartDate.SelectedDate != null) && (tbNoOfSemester.Text != null))
            {
                int weeks = Convert.ToInt32(tbNoOfSemester.Text);
                DateTime date = (DateTime)dpStartDate.SelectedDate;

                newUser.semesterDate = date;
                newUser.week = weeks;

                ModuleListWindows moduleList = new ModuleListWindows(newUser);
                moduleList.Show();
                this.Close();
            }

                
            
        }
    }
}
