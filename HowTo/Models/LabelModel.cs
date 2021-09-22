using System;
namespace HowTo.Models
{
    public class LabelModel : Item
    {
        public LabelModel(string size) : base(size) 
        {
            Text = "Label";
        }
    }
}
