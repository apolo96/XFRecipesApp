using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFRecipesApp.Models;

namespace XFRecipesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipesListPage : ContentPage
    {
        public RecipesListPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this,"change");
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var recipe = e.SelectedItem as RecipesModel;
            if (recipe == null) return;
            await Navigation.PushAsync(new RecipeDetailPage(recipe));
            recipeList.SelectedItem = null;
        }
    }
}