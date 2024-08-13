#if ANDROID
using JustifyLabel.Platforms.Android;
#endif
#if IOS
using JustifyLabel.Platforms.iOS;
#endif
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
                handlers.AddHandler<JustifiedLabel, JustifiedLabelHandler>();
#elif IOS
                handlers.AddHandler(typeof(JustifiedLabel), typeof(JustifiedLabelHandler));
#endif
            }
            );
            return builder;
        }
    }
}
