using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario_a_CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void ButtonSubmitClicked(System.Object sender, System.EventArgs e)
        {
            var input_name = name.Text;
            var input_lastname = lastname.Text;
            var input_age = age.Text;
            var input_occupation = occupationplus.Text;
            var input_language = languageplus.Text; 
            var input_address = address.Text;
            var input_abilities = abilitieplus.Text;
            var input_formation = formationplus.Text;
            var input_w_experience = w_experienceplus.Text; 

            await Application.Current.MainPage.Navigation.PushModalAsync(
                new Page1
                (
                input_name,
                input_lastname,
                input_age, 
                input_occupation,
                input_language,
                input_address,
                input_abilities,
                input_formation,
                input_w_experience
                ), true);

        }

        void ButtonOcupationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your occupation" };
            ocupation.Children.Add(entry);
        }

        void ButtonLanguagesPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your languages" };
            language.Children.Add(entry);
        }

        void ButtonAbilitiesPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your abilities" };
            abilitie.Children.Add(entry);
        }

        void ButtonFormationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your formation" };
            formation.Children.Add(entry);
        }
        void ButtonExperiencePlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your work experience" };
            w_experience.Children.Add(entry);
        }

    }
}
