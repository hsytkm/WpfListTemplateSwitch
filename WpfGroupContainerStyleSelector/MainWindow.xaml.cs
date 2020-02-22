using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfGroupContainerStyleSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var items = MyData.Items;

            ICollectionView view = CollectionViewSource.GetDefaultView(items);
            view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(MyData.Type)));

            DataContext = view;
        }
    }
}
