using Microsoft.Maui;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustifyLabel;

public abstract class JustifiedLabelHandler(IPropertyMapper? PropertyMapper) : LabelHandler(PropertyMapper)
{
    public static void SetPlatformProperties(Microsoft.Maui.Controls.Label label)
    {
        if (label is null)
        {
            return;
        }
        if(label.Handler is null)
        {
            label.HandlerChanged += Label_HandlerChanged;
        }
#if ANDROID
        Platforms.Android.JustifiedLabelHandler.SetPlatformProperties(label.Handler as ILabelHandler,label);
#elif IOS
        Platforms.iOS.JustifiedLabelHandler.SetPlatformProperties(label.Handler as ILabelHandler,label);
#elif MACCATALYST
Platforms.MacCatalyst.JustifiedLabelHandler.SetPlatformProperties(label.Handler as ILabelHandler,label);
#elif WINDOWS
        Platforms.Windows.JustifiedLabelHandler.SetPlatformProperties(label.Handler as ILabelHandler, label);
#elif TIZEN
        Platforms.Tizen.JustifiedLabelHandler.SetPlatformProperties(label.Handler as ILabelHandler,label);
#endif
    }

    private static void Label_HandlerChanged(object? sender, EventArgs e)
    {
        if (sender is Microsoft.Maui.Controls.Label label)
        {
            label.HandlerChanged -= Label_HandlerChanged;
            SetPlatformProperties(label);
        }
    }

    public static bool IsJustified(ILabel? label)
    {
        if (label is JustifiedLabel jLabel)
        {
            return jLabel.JustifyText;
        }
        else if (label is Microsoft.Maui.Controls.Label mauiLabel)
        {
            return JustifyLabel.Label.GetJustifyText(mauiLabel);
        }
        return false;
    }
}

