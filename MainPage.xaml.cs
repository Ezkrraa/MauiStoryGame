using Microsoft.Maui.Graphics.Converters;
using System.Globalization;


namespace MauiStoryGame
{
    public partial class MainPage : ContentPage
    {
        int index = 0;
        string[] rainbow = [
            "#5BCEFA",
            "#F5A9B8",
            "#FFFFFF",
            "#F5A9B8"
        //"#5BCEFA"
        ];

        StringToColourConverter converter = new StringToColourConverter();

        bool GetHaiid = false;

        public MainPage()
        {
            InitializeComponent();

        }


        public void GetData(object sender, EventArgs args)
        {
            string DialogFile = File.ReadAllText("dialogFile.txt");

        }

        /*
        public void StartStory()
        {

        }
        */

        public void SetDialog(object sender, EventArgs args)
        {
            if (!GetHaiid)
            {
                MainText.Text = MainText.Text + "\n\nomg hiiiii  :DDD";
                GetHaiid = true;
            }
            index++;
            while (index >= rainbow.Length)
            {
                index -= rainbow.Length;
            }
            MainText.TextColor = converter.Convert(rainbow[index]);
        }
    }
}



public class StringToColourConverter
{
    public Microsoft.Maui.Graphics.Color Convert(string value)
    {
        ColorTypeConverter converter = new();
        var result = (Microsoft.Maui.Graphics.Color)converter.ConvertFromInvariantString(value);
        return result;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}
