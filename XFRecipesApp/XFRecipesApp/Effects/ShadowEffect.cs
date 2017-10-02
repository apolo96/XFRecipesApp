using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRecipesApp.Effects
{
    public class ShadowEffect : RoutingEffect
    {
        public ShadowEffect() : base("com.apolo96.ShadowEffect")
        {

        }

        public Color ShadowColor { get; set; } = Color.Black;
    }
}
