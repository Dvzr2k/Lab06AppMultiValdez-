using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
         ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
         ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Valdez" });
            employees.Add(new Employee { DisplayName = "Bill Valdez" });
            employees.Add(new Employee { DisplayName = "Dr Geri-beth Valdez" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Valdez" });
            employees.Add(new Employee { DisplayName = "Sheri Valdez" });
            employees.Add(new Employee { DisplayName = "Burt Valdez" });

        }
    }
}