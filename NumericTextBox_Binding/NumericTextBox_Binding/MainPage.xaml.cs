using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NumericTextBox_Binding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }

    public class ObjectConverter : IValueConverter
    {
        // From Entry we get the string value before binding that string value into NumericTextBox,it has to convert to double

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return double.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return double.Parse(value.ToString());

        }
    }

    //ViewModel class to have bindable property
    public class ViewModel : INotifyPropertyChanged
    {

        // Set and Get the "Value" property's bindable property

        private double valueNumeric = 1000;
        public double ValueNumeric
        {
            get { return valueNumeric; }
            set
            {
                valueNumeric = value;
                RaisePropertyChanged("ValueNumeric");
            }
        }

        public void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
