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
        
        public static readonly BindableProperty AnimalUriProperty = BindableProperty.Create(
            nameof(AnimalUri),
            typeof(string),
            typeof(AnimalControl),
            string.Empty
        );
        
        public string Animal
        {
            get
            {
                switch ((string)this.GetValue(AnimalProperty))
                {
                    case "Frog":
                    {
                        this.SetValue(AnimalUriProperty,
                            "https://i.etsystatic.com/isla/910f97/34229353/isla_fullxfull.34229353_lywq3bgq.jpg?version=0");
                    }
                        break;
                    case "Cat":
                    {
                        this.SetValue(AnimalUriProperty,
                            "https://www.dailypaws.com/thmb/nwNtJnMRSJ33nbdzrdsRwSJHMfU=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/anime-cat-names-1204854078-2000-d34f509ae54943d8b78cfb4bf9ba0678.jpg");
                    }
                        break;
                    default:
                    {
                        return null;
                    }
                        break;
                }
                return (string)this.GetValue(AnimalProperty);
            }
            set
            {
                this.SetValue(AnimalProperty, value);
            }
        }

        public string AnimalUri
        {
            get => (string)this.GetValue(AnimalUriProperty);
            set => this.SetValue(AnimalUriProperty, value);
        }
        
        public AnimalControl()
        {
            InitializeComponent();
        }
    }
}