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
            string.Empty,
            propertyChanged: OnAnimalPropertyChanged
        );

        private static void OnAnimalPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if(bindable is AnimalControl animalControl)
            {
                // switch here
                animalControl.AnimalUri = (string)newvalue;
            }
        }

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
    }
}