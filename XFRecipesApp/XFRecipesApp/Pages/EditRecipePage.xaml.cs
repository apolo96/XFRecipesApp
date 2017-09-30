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
    public partial class EditRecipePage : ContentPage
    {
        public EditRecipePage(RecipesModel recipe)
        {
            InitializeComponent();
            BindingContext = recipe;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}