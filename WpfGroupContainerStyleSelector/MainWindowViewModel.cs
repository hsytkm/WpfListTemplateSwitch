using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace WpfGroupContainerStyleSelector
{
    class MainWindowViewModel
    {
        public IList<MyData> SourceItems => MyData.Items;

        public ICollectionView SortedItems { get; }

        public MainWindowViewModel()
        {
            ICollectionView view = CollectionViewSource.GetDefaultView(SourceItems);
            view.GroupDescriptions.Add(new PropertyGroupDescription(nameof(MyData.Type)));
            SortedItems = view;
        }
    }
}
