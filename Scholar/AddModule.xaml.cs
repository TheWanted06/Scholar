﻿using System;
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
    /// Interaction logic for AddModule.xaml
    /// </summary>
    public partial class AddModule : Page
    {
        public AddModule(User user)
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e, User user)
        {
            TheModules module = new TheModules();
            module.Name = txtName.Text;

        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
