# Xamarin-KulenDayz-XamarinForms-Demo

## Reference

* [http://matthewwaring.wordpress.com/2014/07/02/xamarin-forms-6-ways-to-create-listviews-and-tableviews-with-custom-cells/](http://matthewwaring.wordpress.com/2014/07/02/xamarin-forms-6-ways-to-create-listviews-and-tableviews-with-custom-cells/)

## Tips and Tricks

### In Ctor of the Page

*	Problem
	No embeddedresources found for		
		
	Xamarin.Forms.Xaml.XamlParseException: No embeddedresources found for Demo.Pages.DemoTabbedPageInXaml
	at at Xamarin.Forms.Xaml.XamlLoader.Load (Xamarin.Forms.VisualElement,System.Type) <IL 0x0002a, 0x00103>
	at at Xamarin.Forms.Xaml.Extensions.LoadFromXaml<Demo.Pages.DemoTabbedPageInXaml> (Demo.Pages.DemoTabbedPageInXaml,System.Type) <0x0002f>
	at Demo.Pages.DemoTabbedPageInXaml.InitializeComponent () [0x0000c] in /Users/moljac/Projects/HolisticWare/Xamarin-KulenDayz-XamarinForms-Demo/Demo.Pages/Demo.Pages/obj/Debug/DemoTabbedPageInXaml.xaml.g.cs:20
	at Demo.Pages.DemoTabbedPageInXaml..ctor () [0x00008] in /Users/moljac/Projects/HolisticWare/Xamarin-KulenDayz-XamarinForms-Demo/Demo.Pages/Demo.Pages/DemoTabbedPageInXaml.xaml.cs:13
	at Demo.Pages.App.GetMainPage () [0x00001] in /Users/moljac/Projects/HolisticWare/Xamarin-KulenDayz-XamarinForms-Demo/Demo.Pages/Demo.Pages/App.cs:14
	at Demo.Pages.Droid.MainActivity.OnCreate (Android.OS.Bundle) [0x00010] in /Users/moljac/Projects/HolisticWare/Xamarin-KulenDayz-XamarinForms-Demo/Demo.Pages/Demo.Pages.Android/MainActivity.cs:23
	at Android.App.Activity.n_OnCreate_Landroid_os_Bundle_ (intptr,intptr,intptr) [0x00011] in /Users/builder/data/lanes/1148/fd6fa476/source/monodroid/src/Mono.Android/platforms/android-19/src/generated/Android.App.Activity.cs:2179
	at at (wrapper dynamic-method) object.77617b3b-5f01-4f57-a2b0-199f990e2678 (intptr,intptr,intptr) <IL 0x00017, 0x0001f>

*	Resolution/Solution
	*	Remove
		*	bin
		*	obj folders