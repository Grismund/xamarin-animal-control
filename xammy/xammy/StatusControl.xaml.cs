using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xammy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatusControl
    {
        public static readonly BindableProperty LocationNameProperty = BindableProperty.Create(
            nameof(LocationName),
            typeof(string),
            typeof(StatusControl),
            string.Empty
        );

        public string LocationName
        {
            get => (string)this.GetValue(LocationNameProperty);
            set => this.SetValue(LocationNameProperty, value);
        }
        public StatusControl()
        {
            InitializeComponent();
        }
        
    }
}