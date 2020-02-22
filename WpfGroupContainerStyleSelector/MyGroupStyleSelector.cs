using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfGroupContainerStyleSelector
{
    class MyGroupStyleSelector : StyleSelector
    {
        public Style Style1 { get; set; }
        public Style Style2 { get; set; }
        public Style Style3 { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if (!(item is CollectionViewGroup group))
                return base.SelectStyle(item, container);

            return group.Name.ToString() switch
            {
                nameof(MyData.ItemType.Bool) => Style1,
                nameof(MyData.ItemType.Int) => Style2,
                nameof(MyData.ItemType.String) => Style3,
                _ => base.SelectStyle(item, container),
        };
        }
    }
}
