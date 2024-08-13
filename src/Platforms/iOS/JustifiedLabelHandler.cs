using Microsoft.Maui.Handlers;
using UIKit;

namespace JustifyLabel.Platforms.iOS;

public class JustifiedLabelHandler : LabelHandler
{
    private static readonly IPropertyMapper<JustifiedLabel, JustifiedLabelHandler> PropertyMapper = new PropertyMapper<JustifiedLabel, JustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = MapTextAlignment
    };
    public JustifiedLabelHandler():base(PropertyMapper)
    {
        
    }

    public static void MapTextAlignment(ILabelHandler handler, ILabel label)
    {
        bool isJustified = label is JustifiedLabel jLabel && jLabel.JustifyText;

            handler.PlatformView.TextAlignment = isJustified? UITextAlignment.Natural: UITextAlignment.Justified;
        
    }
}