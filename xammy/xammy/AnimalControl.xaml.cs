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
    public partial class AnimalControl
    {
        public static readonly BindableProperty AnimalProperty = BindableProperty.Create(
            nameof(Animal),
            typeof(string),
            typeof(AnimalControl),
            string.Empty
        );
        
        public string Animal
        {
            get => (string)GetValue(AnimalProperty);
            set => SetValue(AnimalProperty, value);
        }

        public string AnimalUri { get; private set; }
        
        public AnimalControl()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == AnimalProperty.PropertyName)
            {
                this.AnimalUri = switch(this.Animal)
                {
                    
                }
            }
        }
    }
}