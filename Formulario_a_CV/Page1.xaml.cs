using PdfSharp.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;


namespace Formulario_a_CV
{
	public partial class Page1 : ContentPage
	{
		private string mainContentName;
		private string mainContentLastname;
		private string mainContentAge;
		private string mainContentOccupation;
		private string mainContentLanguage;
		private string mainContentAddress;
		private string mainContentAbilities;
		private string mainContentFormation;
		private string mainContentW_experience;

		public string MainContentW_experience
		{
			get { return mainContentW_experience; }
			set
			{
				mainContentW_experience = value;
				OnPropertyChanged(nameof(MainContentW_experience));
			}
		}
		public string MainContentFormation
		{
			get { return mainContentFormation; }
			set
			{
				mainContentFormation = value;
				OnPropertyChanged(nameof(MainContentFormation));
			}
		}
		public string MainContentAbilities
		{
			get { return mainContentAbilities; }
			set
			{
				mainContentAbilities = value;
				OnPropertyChanged(nameof(MainContentAbilities));
			}
		}
		public string MainContentAddress
		{
			get { return mainContentAddress; }
			set
			{
				mainContentAddress = value;
				OnPropertyChanged(nameof(MainContentAddress));
			}
		}
		public string MainContentLanguage
		{
			get { return mainContentLanguage; }
			set
			{
				mainContentLanguage = value;
				OnPropertyChanged(nameof(MainContentLanguage));
			}
		}
		public string MainContentOccupation
		{
			get { return mainContentOccupation; }
			set
			{
				mainContentOccupation = value;
				OnPropertyChanged(nameof(MainContentOccupation));
			}
		}
		public string MainContentAge
		{
			get { return mainContentAge; }
			set
			{
				mainContentAge = value;
				OnPropertyChanged(nameof(MainContentAge));
			}
		}
		public string MainContentLastname
		{
			get { return mainContentLastname; }
			set
			{
				mainContentLastname = value;
				OnPropertyChanged(nameof(MainContentLastname));
			}
		}
		public string MainContentName
		{
			get { return mainContentName; }
			set
			{
				mainContentName = value;
				OnPropertyChanged(nameof(MainContentName));
			}
		}

		public Page1(
			   string mainContentName,
			   string mainContentLastname,
			   string mainContentAge, 
			   string mainContentOccupation, 
			   string mainContentLanguage, 
			   string mainContentAddress,
			   string mainContentAbilities,
			   string mainContentFormation,
			   string mainContentW_experience)
        {
            InitializeComponent();
            BindingContext = this;
            MainContentName = mainContentName;
			MainContentLastname = mainContentLastname;
            MainContentAge = mainContentAge;
            MainContentOccupation = mainContentOccupation;
			MainContentLanguage = mainContentLanguage;
			MainContentAddress = mainContentAddress;
			MainContentAbilities = mainContentAbilities;
			MainContentFormation = mainContentFormation;
			MainContentW_experience = mainContentW_experience;
        }

		private async void Button_Save_CV(object sender, EventArgs e)
		{
			var pdf = PDFManager.GeneratePDFFromView(PagetoPDF);
			string fn = "CV.pdf";
			var basspath = System.IO.Path.Combine(FileSystem.CacheDirectory, fn);
			pdf.Save(basspath);

			var message = new EmailMessage
			{
				Subject = "CV from application",
				Body = "Hello, this is your CV from application",
			};

			message.Attachments.Add(new EmailAttachment(basspath));
			await Email.ComposeAsync(message);

		}

	}

}


