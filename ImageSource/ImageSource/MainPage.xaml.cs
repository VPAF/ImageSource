using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageSource
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    public int i = 1;

	    private void BtnNext_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Next","Next","cancel");

	        if (i <= 10)
	        {
	            i = i + 1;
	        }
	        //image.Source = ImageSource.FromResource("…resourceId…");

	        image.Source = new UriImageSource
	        {
	            Uri = new Uri("https://placeimg.com/1920/1080/any/" + i),
	            CachingEnabled = false,
	            CacheValidity = TimeSpan.FromHours(1)
	        };
        }


	    private void BtnPrevious_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Previous", "Previous", "cancel");

	        if (i > 1)
	        {
	            i = i - 1;
	        }
	        //image.Source = ImageSource.FromResource("…resourceId…");

	        image.Source = new UriImageSource
	        {
	            Uri = new Uri("https://placeimg.com/1920/1080/any/" + i),
	            CachingEnabled = false,
	            CacheValidity = TimeSpan.FromHours(1)
	        };
        }
	}
}
