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
    /// Interaction logic for Module.xaml
    /// </summary>
    public partial class TheModules : Window
    {
        public TheModules(User user, int a)
        {
            InitializeComponent();
            if(a == 1)
            {
                NewFrame.Content = new AddModule(user);
            }
            if(a == 2)
            {
                NewFrame.Content = new ModuleDetails(user);
            }
        }
    }
}
