﻿using Microsoft.Maui.Handlers;
using UIKit;

namespace JustifyLabel.Platforms.iOS;

public class JustifiedLabelHandler : JustifyLabel.JustifiedLabelHandler
{
    private static readonly IPropertyMapper<JustifiedLabel, JustifiedLabelHandler> PropertyMapper = new PropertyMapper<JustifiedLabel, JustifiedLabelHandler>(Mapper)
    {
        [nameof(JustifiedLabel.JustifyText)] = SetPlatformProperties,
        [nameof(JustifiedLabel.Handler)] = SetPlatformProperties,
        [nameof(JustifiedLabel.IsLoaded)] = SetPlatformProperties
    };
    public JustifiedLabelHandler():base(PropertyMapper)
    {
        
    }

    public static void SetPlatformProperties(ILabelHandler? handler, ILabel? label)
    {
        bool isJustified = IsJustified(label);
        if (handler is not null){
                handler.PlatformView.TextAlignment = isJustified ? UITextAlignment.Justified : UITextAlignment.Natural;
        }
        
    }
}