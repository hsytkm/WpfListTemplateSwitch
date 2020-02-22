using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfContainerStyleSelector
{
    class MyItemContaierStyleSelector : StyleSelector
    {
        public Style Style1 { get; set; }
        public Style Style2 { get; set; }
        public Style Style3 { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if (!(item is MyData myData))
                return base.SelectStyle(item, container);

            return myData.Type switch
            {
                MyData.ItemType.Bool => Style1,
                MyData.ItemType.Int => Style2,
                MyData.ItemType.String => Style3,
                _ => base.SelectStyle(item, container),
            };
        }
    }
}
