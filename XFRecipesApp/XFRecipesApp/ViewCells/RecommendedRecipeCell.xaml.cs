using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFRecipesApp.Pages;

namespace XFRecipesApp.ViewCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecommendedRecipeCell : ViewCell
	{
		public RecommendedRecipeCell ()
		{
			InitializeComponent ();
            overallContent.Resources["BannerStyle"] = App.Current.Resources["RecommendedBannerStyle"];
            overallContent.Resources["CellContentStyle"] = App.Current.Resources["OverallCellContentStyle"];
            overallContent.Resources["NameStyle"] = App.Current.Resources["RecipeNameStyle"];
            overallContent.Resources["DetailsStyle"] = App.Current.Resources["CellPrepDetailsStyle"];

            MessagingCenter.Subscribe<RecipesListPage>(this, "change", (obj) => ChangeStyles());
        }

        bool isBold = false;
        void ChangeStyles()
        {
            if (isBold)
            {
                // Revert to normal
                overallContent.Resources["BannerStyle"] = App.Current.Resources["RecommendedBannerStyle"];
                overallContent.Resources["CellContentStyle"] = App.Current.Resources["OverallCellContentStyle"];
                overallContent.Resources["NameStyle"] = App.Current.Resources["RecipeNameStyle"];
                overallContent.Resources["DetailsStyle"] = App.Current.Resources["CellPrepDetailsStyle"];
            }
            else
            {
                // Show the bold colors
                overallContent.Resources["BannerStyle"] = overallContent.Resources["BoldRecommendedBannerStyle"];
                overallContent.Resources["CellContentStyle"] = overallContent.Resources["BoldOverallCellContentStyle"];
                overallContent.Resources["NameStyle"] = overallContent.Resources["BoldRecipeNameStyle"];
                overallContent.Resources["DetailsStyle"] = overallContent.Resources["BoldCellPrepDetailsStyle"];                
            }

            isBold = !isBold;
        }
    }
}