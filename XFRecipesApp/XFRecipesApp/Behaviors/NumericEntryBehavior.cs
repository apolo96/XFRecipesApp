using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRecipesApp.Behaviors
{
    public class NumericEntryBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += textChangedHandler;
        }

        private void textChangedHandler(object sender, TextChangedEventArgs e)
        {
            double _out;
            if (string.IsNullOrEmpty(e.NewTextValue)) return;
            if (!double.TryParse(e.NewTextValue, out _out))
                ((Entry)sender).Text = e.OldTextValue;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= textChangedHandler;
        }
    }
}
