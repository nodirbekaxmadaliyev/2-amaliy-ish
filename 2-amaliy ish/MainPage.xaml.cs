namespace _2_amaliy_ish
{
    public partial class MainPage : ContentPage
    {
        public class Item
        {
            public String Name { get; set; }
        }
        public List<Item> Items;
        public MainPage()
        {
            InitializeComponent();
            Items = new List<Item>
            {
                new Item {Name = "Samsung" },
                new Item {Name = "Apple"},
                new Item {Name = "Redmi"},
                new Item {Name = "Google"}
            };
            MyCollectionViews.ItemsSource = Items;
        }

        
    }

}
