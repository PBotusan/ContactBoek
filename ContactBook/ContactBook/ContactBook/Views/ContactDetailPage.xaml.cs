using ContactBook.Persistence;
using ContactBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactBook.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
        public ContactDetailPage(ContactViewModel viewModel)
        {
            InitializeComponent();

            var contactStore = new SQLiteContactStore(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();

            BindingContext = new ContactDetailViewModel(
           viewModel ?? new ContactViewModel(), contactStore, pageService);
        }
    }
}