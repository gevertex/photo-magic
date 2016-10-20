using Xamarin.Forms;

namespace PhotoMagic
{
	public partial class PhotoMagicPage : ContentPage
	{
		public PhotoMagicPage ()
		{
			InitializeComponent ();
            #if __IOS__ || __ANDROID__
            PhotoUtils2.Drawing draw = new PhotoUtils2.Drawing();
            #endif
		}
	}
}
