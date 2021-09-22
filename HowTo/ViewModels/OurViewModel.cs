using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HowTo.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HowTo.ViewModels
{
    public class OurViewModel : BaseViewModel
    {
        private Random _random = new Random();
        private ObservableCollection<Item> _items;

        public ObservableCollection<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public OurViewModel()
        {
            Title = "FlowLayout Using FlexLayout";
            List<string> sizes = new List<string>
            {
                "S", "M", "L"
            };
            Items = new ObservableCollection<Item>(new List<Item>
            {
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new LineBreakModel(),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new LineBreakModel(),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new LineBreakModel(),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LineBreakModel(),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
                new DateModel(sizes[_random.Next(0, 3)]),
                new LineBreakModel(),
                new LabelModel(sizes[_random.Next(0, 3)]),
                new EntryModel(sizes[_random.Next(0, 3)]),
            });
            // sizes[_random.Next(0, 3)];
        }
    }
}
