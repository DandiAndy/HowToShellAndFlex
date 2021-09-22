using System;
using HowTo.Models;
using Xamarin.Forms;
namespace HowTo.Selector
{
    public class ItemSelector : DataTemplateSelector
    {
        public DataTemplate LabelTemplate { get; set; }
        public DataTemplate EntryTemplate { get; set; }
        public DataTemplate DateTemplate { get; set; }
        public DataTemplate LineBreakTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case DateModel dateModel:
                    return DateTemplate;
                case LabelModel labelModel:
                    return LabelTemplate;
                case EntryModel entryModel:
                    return EntryTemplate;
                case LineBreakModel lineBreakModel:
                    return LineBreakTemplate;
                default:
                    throw new ArgumentException($"{item.GetType()} must be of type {nameof(Item)} to be used in {nameof(ItemSelector)}.");
            }
        }
    }
}
