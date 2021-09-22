using System;
namespace HowTo.Models
{
    public class EntryModel : Item
    {
        public EntryModel(string size) : base(size)
        {
            Text = "Entry";
        }
    }
}
