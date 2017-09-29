using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFRecipesApp.Models;
using XFRecipesApp.ViewCells;

namespace XFRecipesApp.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        DataTemplate recipeTemplate;
        DataTemplate recommendedRecipeTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedRecipeTemplate = new DataTemplate(typeof(RecommendedRecipeCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as RecipesModel;
            if (recipe == null) return null;
            return recipe.IsRecommended ? recommendedRecipeTemplate : recipeTemplate;
        }
    }
}
