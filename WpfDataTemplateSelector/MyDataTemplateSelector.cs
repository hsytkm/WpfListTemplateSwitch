using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfDataTemplateSelector
{
    class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Template1 { get; set; }
        public DataTemplate Template2 { get; set; }
        public DataTemplate Template3 { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (!(item is CollectionViewGroup group))
                return base.SelectTemplate(item, container);

            return group.Name.ToString() switch
            {
                nameof(MyData.ItemType.Bool) => Template1,
                nameof(MyData.ItemType.Int) => Template2,
                nameof(MyData.ItemType.String) => Template3,
                _ => base.SelectTemplate(item, container),
            };
        }
    }
}
