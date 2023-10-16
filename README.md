# Adding SfNumericTextBox reference
You can add SfNumericTextBox reference using one of the following methods:

## Method 1: Adding SfNumericTextBox reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfNumericTextBox to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.SfNumericTextBox, and then install it.

## Method 2: Adding SfNumericTextBox reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfNumericTextBox control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

## Method 3: Adding SfNumericTextBox assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

# Create a simple SfNumericTextBox
The SfNumericTextBox control is configured entirely in C# code or by using XAML markup.

The following steps explain how to create a SfNumericTextBox and configure its elements,

*   Adding namespace for the added assemblies.

**[XAML]**
```
xmlns:syncfusion="clr-namespace:Syncfusion.SfNumericTextBox.XForms;assembly=Syncfusion.SfNumericTextBox.XForms"
```
*   Now, add the SfNumericTextBox control with a required optimal name by using the included namespace.

**[XAML]**
```
<ContentPage.Content>
     <syncfusion:SfNumericTextBox />	
</ContentPage.Content>
```
# How to work with NumericTextBox two way binding with an Entry control
Create a ViewModel class and add a property to bind the Value property in NumericTextBox as mentioned in the below code sample.
**[C#]**
```

public class ViewModel : INotifyPropertyChanged
{
 public event PropertyChangedEventHandler PropertyChanged;
 private float _value=5;
 
 public float Value
 {
    get{ return _value;}
    set{_value = value;RaisePropertyChanged ();}
 }
 
protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
 {
   if (this.PropertyChanged != null)
    {
      this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
```
Initialize the SfNumericTextBox control and bind the value property as shown in the below code sample.

**[XAML]**
```
<ContentPage.Content>
<StackLayout >
    <syncfusion:SfNumericTextBox x:Name="numericTextBox" 
                                 Value="{Binding Value, Mode=TwoWay}"
                                 HorizontalOptions="Center" 
                                 VerticalOptions="Center" />
</StackLayout>
</ContentPage.Content>

```
## How to run this application?

To run this application, you need to first clone the How-to-work-with-NumericTextBox-two-way-binding-with-an-Entry-controlrepository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.