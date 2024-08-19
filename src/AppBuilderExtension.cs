using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustifyLabel
{
    public static class AppBuilderExtension
    {
        public static MauiAppBuilder UseJustifiedLabel(this MauiAppBuilder builder)
        {
            builder.ConfigureMauiHandlers(handlers =>
            {
#if ANDROID                
handlers.AddHandler<JustifiedLabel, JustifyLabel.Platforms.Android.JustifiedLabelHandler>();
#elif IOS                
                handlers.AddHandler<JustifiedLabel, JustifyLabel.Platforms.iOS.JustifiedLabelHandler>();
#elif MACCATALYST                
handlers.AddHandler<JustifiedLabel, JustifyLabel.Platforms.MacCatalyst.JustifiedLabelHandler>();
#elif WINDOWS               
handlers.AddHandler<JustifiedLabel, JustifyLabel.Platforms.Windows.JustifiedLabelHandler>();
#elif TIZEN
                handlers.AddHandler<JustifiedLabel, JustifyLabel.Platforms.Tizen.JustifiedLabelHandler>();
#endif

            }
            );
            return builder;
        }
    }
}
