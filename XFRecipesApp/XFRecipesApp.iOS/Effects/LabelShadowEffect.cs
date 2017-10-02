using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XFRecipesApp.iOS.Effects;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using XFRecipesApp.Effects;

[assembly: ResolutionGroupName("com.apolo96")]
[assembly: ExportEffect(typeof(LabelShadowEffect),"ShadowEffect")]
namespace XFRecipesApp.iOS.Effects
{
    public class LabelShadowEffect : PlatformEffect
    {
        UIColor oldColor;
        CGSize oldOffSet;

        protected override void OnAttached()
        {
            var c = Control as UILabel;
            oldColor = c.ShadowColor;
            oldOffSet = c.ShadowOffset;

            var routingEffect = (ShadowEffect)Element.Effects.First((arg) => arg is ShadowEffect);
            var shadowColor = routingEffect.ShadowColor;

            c.ShadowColor = shadowColor.ToUIColor();
            c.ShadowOffset = new CGSize(2, 2);
        }

        protected override void OnDetached()
        {
            var c = Control as UILabel;
            c.ShadowColor = oldColor;
            c.ShadowOffset = oldOffSet;
        }
    }
}