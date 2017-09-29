using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRecipesApp.ValueConverters
{
    public class RecipeToImageValueConverter : IValueConverter
    {
        public string AssemblyDirectory { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imageName = value as string;
            if (string.IsNullOrEmpty(imageName)) return null;
            var imagePath = $"{AssemblyDirectory}.{imageName}";
            return ImageSource.FromResource(imagePath);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
