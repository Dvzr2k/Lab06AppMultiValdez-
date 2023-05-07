using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewGroup : ContentPage
	{
		public ListViewGroup ()
		{
			InitializeComponent ();

            var items = new List<string> {
                "Alison", "Adan", "Bin", "Bob", "Catalina", "Carlos", "Diego", "Daniel"
            };

            var grouped = items.OrderBy(s => s)
                               .GroupBy(s => s[0].ToString())
                               .Select(g => new Grouping<string, string>(g.Key, g));

            listView.ItemsSource = grouped;
        }
	}
}