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
		public RecipeDetailPage (RecipesModel recipe)
		{
			InitializeComponent ();
            BindingContext = recipe;
		}
	}
}