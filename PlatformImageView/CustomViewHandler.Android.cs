using Android.Content;
using Android.Widget;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

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
            return new CustomControl(Context);
        }

        protected override void ConnectHandler(CustomControl platformView)
        {
            base.ConnectHandler(platformView);
        }

        public static void MapItemContent(CustomViewHandler handler, CustomView view)
        {
            if (view != null && view.ItemContent != null)
            {
                handler.PlatformView.AddView((Android.Views.View)view.ItemContent.ToPlatform(handler.MauiContext!));
            }
        }

        public static void MapItemTemplateContent(CustomViewHandler handler, CustomView view)
        {
                if (view != null && view.ItemTemplate != null)
                {
                     var mauiView=(View)view.ItemTemplate.CreateContent();
                var platform= (Android.Views.View)mauiView.ToPlatform(handler.MauiContext!);
                handler.PlatformView.AddView(platform);
                
                }
        }


    }

    public class CustomControl : FrameLayout
    {

        public CustomControl(Context context) : base(context)
        {
           
        }


    }
}
