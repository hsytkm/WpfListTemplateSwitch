using System;
using System.Windows;

namespace WpfContainerStyleSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = MyData.Items;
        }
    }
}
