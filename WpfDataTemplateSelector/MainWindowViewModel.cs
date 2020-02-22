using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace WpfDataTemplateSelector
{
    class MainWindowViewModel
    {
        public IList<MyData> SourceItems => MyData.Items;

        public ICollectionView SortedItems { get; }

        public MainWindowViewModel()
        {
            //var view = new ListCollectionView(SourceItems);
            ICollectionView view = CollectionViewSource.GetDefaultView(SourceItems);

            view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(MyData.Type)));
            view.SortDescriptions.Add(new SortDescription(nameof(MyData.Type), ListSortDirection.Descending));
            view.SortDescriptions.Add(new SortDescription(nameof(MyData.Value), ListSortDirection.Ascending));

            SortedItems = view;
        }
    }
}
