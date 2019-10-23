# com.ptdave.xamarin
Simple tools to help improve the speed of development

## Initialization

### Android
Inside of your main activity, please initialize the plugin in order to use the DependencyService injections like so:
```
com.ptdave.xamarin.Helper.Initialize(this, savedInstanceState);
```

### iOS
Inside of your AppDelegate, please initialize the plugin in order to use the DependencyService injections like so:
```
com.ptdave.xamarin.Helper.Initialize();
```

## File Helper
The file helper is intended to prevent having to create your own file location handlers for plugins like SQLite or others.

```
var fileService = DependencyService.Get<IFileHelper>();
var dbPath = fileService.DatabaseFile("data.db");
```

Additional paths will become available as necessary


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

## Behaviors
Several behaviors are there to simplify some work and validation
- Minimum Length - Does the input string meet the required length?
- RegExp Tester - Does the input match the enterred regex?
- Had Focus - Has the field had focus?

## Value Converters
These are some simple converters
 - Invert (false to true, true to false)
 - IsNull (Bound object is null (true/false))
 - IsNotNull (Bound object is not null (true/false))
 - StringLength (Returns the length of the bound string, defaults 0)


 Accessible by adding the following to your ContentPage Xaml:
 ```
xmlns:vc="clr-namespace:com.ptdave.xamarin.ValueConverters;assembly=com.ptdave.xamarin"
```

The following is an example of adding it to the ResourceDictionary for that ContentPage
```
<ContentPage.Resources>
    <ResourceDictionary>
        <vc:Invert x:Key="Invert" />
        <vc:IsNotNull x:Key="IsNotNull" />
        <vc:IsNull x:Key="IsNull" />
        <vc:StringLength x:Key="StringLength" />
    </ResourceDictionary>
</ContentPage.Resources>
```

## Contributing
I accept pull request. I just ask that you please discuss with me first what you want to accomplish to see if it fits the project.

## Acknowledgements
The following people have either helped in the project or allowed their code snippets to be used in the project.

- Brandon Minick @TheCodeTraveler ( Environment for Theme inspired by his code found [https://codetraveler.io/2019/09/11/check-for-dark-mode-in-xamarin-forms/](here))