using System;
using Microsoft.Maui.Platform;

namespace JustifyLabel;

public sealed class Label
{
#pragma warning disable CS0628 // New protected member declared in sealed type
    protected Label() { }
#pragma warning restore CS0628 // New protected member declared in sealed type

    public static readonly BindableProperty JustifyTextProperty = BindableProperty.CreateAttached(
        propertyName: nameof(JustifiedLabel.JustifyText),
        returnType: typeof(bool),
        declaringType: typeof(JustifiedLabel),
        defaultValue: true,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: OnJustifyTextPropertyChanged,
        propertyChanging: OnJustifyTextPropertyChanging,
        coerceValue: null,
        validateValue: OnJustifyTextPropertyValidateValue,
        defaultValueCreator: null
    );

    private static bool OnJustifyTextPropertyValidateValue(BindableObject bindable, object value)
    {
        if (bindable is Microsoft.Maui.Controls.Label label && value is bool b && b)
        {
            JustifiedLabelHandler.SetPlatformProperties(label);
        }

        return true;
    }

    private static void OnJustifyTextPropertyChanging(
        BindableObject bindable,
        object oldValue,
        object newValue
    )
    { }

    private static void OnJustifyTextPropertyChanged(
        BindableObject bindable,
        object oldValue,
        object newValue
    )
    {
        if (bindable is Microsoft.Maui.Controls.Label label)
        {
            JustifiedLabelHandler.SetPlatformProperties(label);
        }
    }

    public static bool GetJustifyText(BindableObject view)
    {
        return (bool)view.GetValue(JustifyTextProperty);
    }

    public static void SetJustifyText(BindableObject view, bool value)
    {
        view.SetValue(JustifyTextProperty, value);
    }
}

// All the code in this file is included in all platforms.
public class JustifiedLabel : Microsoft.Maui.Controls.Label
{
    public static readonly BindableProperty JustifyTextProperty = BindableProperty.Create(
        propertyName: nameof(JustifyText),
        returnType: typeof(bool),
        declaringType: typeof(JustifiedLabel),
        defaultValue: true,
        defaultBindingMode: BindingMode.OneWay
    );

    public bool JustifyText
    {
        get => (bool)GetValue(JustifyTextProperty);
        set => SetValue(JustifyTextProperty, value);
    }
}
