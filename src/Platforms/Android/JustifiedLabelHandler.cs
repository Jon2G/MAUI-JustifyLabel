using Android.OS;
using Android.Text;
using Microsoft.Maui.Handlers;

namespace JustifyLabel.Platforms.Android;

public class JustifiedLabelHandler : JustifyLabel.JustifiedLabelHandler
{
    private static readonly IPropertyMapper<
        JustifyLabel.JustifiedLabel,
        JustifiedLabelHandler
    > PropertyMapper = new PropertyMapper<JustifyLabel.JustifiedLabel, JustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = SetPlatformProperties
    };

    public JustifiedLabelHandler() : base(PropertyMapper)
    {
    }
    public static void SetPlatformProperties(ILabelHandler? handler, ILabel? label)
    {
        bool isJustified = IsJustified(label);
        if(handler is null)
        {
            return;
        }
        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
        {
            handler.PlatformView.BreakStrategy = isJustified
                ? BreakStrategy.Balanced
                : BreakStrategy.Simple;
        }
        if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
        {
            handler.PlatformView.JustificationMode = isJustified
                ? JustificationMode.InterWord
                : JustificationMode.None;
        }
    }
}
