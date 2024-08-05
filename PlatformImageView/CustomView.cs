// File: MyCustomView.cs
using CommunityToolkit.Maui.Behaviors;

namespace PlatformImageView
{ 
    public class CustomView : ContentView
    {

        public static readonly BindableProperty ItemContentProperty =
       BindableProperty.Create(nameof(ItemContent), typeof(View), typeof(CustomView), null, BindingMode.Default, null, null);

        /// <summary>
        /// Gets or sets the value of ItemContent.  It is a view that can be placed as an item in <see cref="SfRotatorItem"/>.
        /// </summary>
        public View ItemContent
        {
            get { return (View)this.GetValue(ItemContentProperty); }
            set { this.SetValue(ItemContentProperty, value); }
        }

        public static readonly BindableProperty ItemTemplateProperty =
     BindableProperty.Create(nameof(ItemTemplate), typeof(DataTemplate), typeof(CustomView), null, BindingMode.Default, null, null);

        /// <summary>
        /// Gets or sets the value of ItemContent.  It is a view that can be placed as an item in <see cref="SfRotatorItem"/>.
        /// </summary>
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)this.GetValue(ItemTemplateProperty); }
            set { this.SetValue(ItemTemplateProperty, value); }
        }

        public CustomView()
        {

        }
       
    }
}
