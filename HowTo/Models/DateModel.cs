using System;
namespace HowTo.Models
{
    public class DateModel : Item
    {
        public DateModel(string size) : base(size) 
        {
            Text = "Date";
        }
    }
}
