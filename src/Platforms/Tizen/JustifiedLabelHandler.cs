using Microsoft.Maui.Handlers;
using TizenTextAligment = Tizen.UIExtensions.Common.TextAlignment;
namespace JustifyLabel.Platforms.Tizen;
// All the code in this file is only included on Mac Catalyst.
public class JustifiedLabelHandler : LabelHandler
{
    private static readonly IPropertyMapper<JustifiedLabel, JustifiedLabelHandler> PropertyMapper = new PropertyMapper<JustifiedLabel, JustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = SetPlatformProperties
    };
    public JustifiedLabelHandler() : base(PropertyMapper)
    {

    }
    public static void SetPlatformProperties(ILabelHandler? handler, ILabel? label)
    {
        //  bool isJustified = IsJustified(label);
        //TODO: NOT SURE HOW TO MAKE THIS ON TIZEN ANY HELP IS WELCOME :)
        //handler.PlatformView.HorizontalTextAlignment = isJustified ? TizenTextAligment. : UITextAlignment.Justified;

    }
}
