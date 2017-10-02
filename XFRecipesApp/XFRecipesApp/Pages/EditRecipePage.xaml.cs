using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFRecipesApp.Models;
using XFRecipesApp.Storage;

namespace XFRecipesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditRecipePage : ContentPage
    {
        RecipesModel _recipe;
        RecipesModel _originalRecipe;

        bool isNew = false;

        public EditRecipePage()
        {
            InitializeComponent();
            _recipe = new RecipesModel();
            BindingContext = _recipe;
            isNew = true;
        }

        public EditRecipePage(RecipesModel recipe)
        {
            InitializeComponent();
            _originalRecipe = recipe;
            mealPicker.SelectedIndex = mealPicker.Items.IndexOf(_originalRecipe.MealType);
            difficultyPicker.SelectedIndex = difficultyPicker.Items.IndexOf(_originalRecipe.Difficulty);
            BindingContext = recipe;
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            _recipe.Difficulty = difficultyPicker.Items[difficultyPicker.SelectedIndex];
            _recipe.MealType = mealPicker.Items[mealPicker.SelectedIndex];
            _recipe.ImageName = "burger.jpg";
            if (isNew)
            {
                var grouping = RecipesStorage.AllRecipesGroup.First(arg => arg.Title == _recipe.Difficulty);
                grouping.Add(_recipe);
            }
            await Navigation.PopModalAsync();
        }
    }
}