namespace JustifyLabel
{
    // All the code in this file is included in all platforms.
    public class JustifiedLabel : Label
    {
        public static readonly BindableProperty JustifyTextProperty =
            BindableProperty.Create(
                propertyName: nameof(JustifyText),
                returnType: typeof(bool),
                declaringType: typeof(JustifiedLabel),
                defaultValue: false,
                defaultBindingMode: BindingMode.OneWay
            );

        public bool JustifyText
        {
            get => (bool)GetValue(JustifyTextProperty);
            set => SetValue(JustifyTextProperty, value);
        }
    }
}
