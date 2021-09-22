using System;
using HowTo.ViewModels;

namespace HowTo.Models
{
    public class Item : BaseViewModel
    {
        private string _size;

        public Item(string size)
        {
            Size = size;
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public string Size
        {
            get => _size;
            set => SetProperty(ref _size, value);
        }
    }
}
