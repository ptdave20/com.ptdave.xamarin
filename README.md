# com.ptdave.xamarin
Simple tools to help improve the speed of development

## Font Helpers
Simple addons to retrieve all the font unicode values for FontAwesome 5 and Material Icons

Add the following to your xml

```
    xmlns:fonthelper="clr-namespace:com.ptdave.xamarin.FontHelpers;assembly=com.ptdave.xamarin"
```

Then you can access it easily like so (Your font family may vary):
```
                <Image>
                    <Image.Source>
                        <FontImageSource
                            FontFamily="{StaticResource fa-fab}"
                            Glyph="{x:Static fonthelper:FAB.Microsoft}"
                            Size="40"
                            Color="Black" />
                    </Image.Source>
                </Image>
```

## Value Converters
These are some simple converters
 - Invert (false to true, true to false)
 - IsNull (Bound object is null (true/false))
 - IsNotNull (Bound object is not null (true/false))
 - StringLength (Returns the length of the bound string, defaults 0)
