using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace WpfDataTemplateSelector
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

            //var view = new ListCollectionView(items);
            ICollectionView view = CollectionViewSource.GetDefaultView(items);

            view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(MyData.Type)));
            view.SortDescriptions.Add(new SortDescription(nameof(MyData.Type), ListSortDirection.Descending));
            view.SortDescriptions.Add(new SortDescription(nameof(MyData.Value), ListSortDirection.Ascending));

            DataContext = view;
        }
    }
}
