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
                if (animalControl.Animal == "Frog")
                {
                    animalControl.AnimalUri =
                        "https://i.etsystatic.com/isla/910f97/34229353/isla_fullxfull.34229353_lywq3bgq.jpg?version=0";

                } else if (animalControl.Animal == "Cat")
                {
                    animalControl.AnimalUri = "https://www.dailypaws.com/thmb/nwNtJnMRSJ33nbdzrdsRwSJHMfU=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/anime-cat-names-1204854078-2000-d34f509ae54943d8b78cfb4bf9ba0678.jpg";
                }
            }
        }

        public string Animal
        {
            get => (string)GetValue(AnimalProperty);
            set => SetValue(AnimalProperty, value);
        }

        private string animalUri = "";
        public string AnimalUri
        {
            get => animalUri;
            private set { animalUri = value; OnPropertyChanged(); }
        }

        public AnimalControl()
        {
            InitializeComponent();
        }
    }
}