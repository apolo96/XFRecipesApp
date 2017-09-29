using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFRecipesApp.Models
{
    public class RecipesGroupingModel : List<RecipesModel>
    {
        public string Title { get; set; }

        public string ShortName { get; set; }

        public RecipesGroupingModel(string _title, string _shortName)
        {
            Title = _title;
            ShortName = _shortName;
        }
    }
}
