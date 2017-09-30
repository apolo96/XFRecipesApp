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
	public partial class RecipeDetailPage : ContentPage
	{
        RecipesModel _recipe;

		public RecipeDetailPage (RecipesModel recipe)
		{
			InitializeComponent ();
            _recipe = recipe;
            BindingContext = recipe;
		}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var editRecipePage = new NavigationPage(new EditRecipePage(_recipe));
            await Navigation.PushModalAsync(editRecipePage);
        }
    }
}