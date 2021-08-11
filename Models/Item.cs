using System.Collections.Generic;

namespace TodoList.Models
{
    public class Item
    {
        public int Id { get; }
        public string Text { get; set; }
        public bool Checked { get; set; }
        private static readonly List<Item> _instances = new() { };

        public Item(string text)
        {
            Id = _instances.Count;
            Text = text;
            Checked = false;
            _instances.Add(this);
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}