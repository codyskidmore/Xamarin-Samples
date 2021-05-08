using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewTutorial
{
    public partial class MainPage : ContentPage
    {
        public ICollection<Monkey> Monkeys { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Monkeys = Repository.GetMonkeys();
            BindingContext = this;
        }

        private void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Monkey selectedItem = e.CurrentSelection[0] as Monkey;
        }
    }
}
