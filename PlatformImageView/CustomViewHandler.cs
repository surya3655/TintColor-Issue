using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformImageView
{
    public partial class CustomViewHandler
    {
        public static IPropertyMapper<CustomView, CustomViewHandler> PropertyMapper = new PropertyMapper<CustomView, CustomViewHandler>(ViewHandler.ViewMapper)
        {
            
        };
    }
}
