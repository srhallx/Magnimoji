using Xamarin.Forms;

namespace Magnimoji
{
	public partial class MagnimojiPage : ContentPage
	{
		public MagnimojiPage()
		{
			InitializeComponent();

			MyEntry.TextChanged += MyEntry_TextChanged;;
		}

		void MyEntry_TextChanged(object sender, TextChangedEventArgs e)
		{

			if (MyEntry.Text.Length > 0)
			{
				emoji.Text = MyEntry.Text;
				MyEntry.Text = "";
			}
		}
	}
}
