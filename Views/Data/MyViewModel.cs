// Models/MyViewModel.cs

namespace Mech.Models
{
    public class MyItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class MyViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public List<MyItem> Items { get; set; }
    }
}
