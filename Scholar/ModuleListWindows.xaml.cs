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
using System.Windows.Shapes;

namespace Scholar
{
    /// <summary>
    /// Interaction logic for ModuleListWindows.xaml
    /// </summary>
    public partial class ModuleListWindows : Window
    {
        public ModuleListWindows(User user)
        {
            InitializeComponent();
            
        }

        private void ViewModule_Click(object sender, RoutedEventArgs e, User user)
        {
            TheModules module = new TheModules(user, 1);
            module.Show();
            this.Hide();
        }

        private void AddModule_Click(object sender, RoutedEventArgs e, User user)
        {
            TheModules module = new TheModules(user, 2);
            module.Show();
            this.Hide();

        }

    }
}
