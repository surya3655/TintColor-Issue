// File: Platforms/Windows/Handlers/MyCustomViewHandler.cs
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.GTKSpecific;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PlatformImageView;

namespace PlatformImageView
{
    public partial class CustomViewHandler : ViewHandler<CustomView, CustomControl>
    {
        public static IPropertyMapper<CustomView, CustomViewHandler> Mapper =
            new PropertyMapper<CustomView, CustomViewHandler>(ViewHandler.ViewMapper)
            {
                [nameof(CustomView.ItemContent)] = MapItemContent,
                [nameof(CustomView.ItemTemplate)] = MapItemTemplateContent,
            };

        
        

        public static CommandMapper<CustomView, CustomViewHandler> CommandMapper = new(ViewCommandMapper)
        {
           
        };

        public CustomViewHandler() : base(Mapper, CommandMapper)
        {
        }

        protected override CustomControl CreatePlatformView()
        {
            return new CustomControl();
        }

        protected override void ConnectHandler(CustomControl platformView)
        {
            base.ConnectHandler(platformView);
        }

  

        public static void MapItemContent(CustomViewHandler handler, CustomView view)
        {
            if (view != null && view.ItemContent != null)
            {
                handler.PlatformView.Content = view.ItemContent.ToPlatform(handler.MauiContext!);
            }
        }

        public static void MapItemTemplateContent(CustomViewHandler handler, CustomView view)
        {
                if (view != null && view.ItemTemplate != null)
                {
                     var mauiView=(View)view.ItemTemplate.CreateContent();
                    handler.PlatformView.Content = mauiView.ToPlatform(handler.MauiContext!);
                }
        }


    }

    public class CustomControl:ContentControl
    {
        public CustomControl()
        {
          
          
        }

        private void ContentPropertyChanged(DependencyObject sender, DependencyProperty dp)
        {
            
        }
    }
}
