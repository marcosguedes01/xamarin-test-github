using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyFormsApp.Views
{
    public partial class UIXaml : ContentPage
    {
        public UIXaml()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.ViewModel();

            #region exemplo sem utilizar a view model
            //this.search.Clicked += async (object sender, EventArgs e) =>
            //{
            //    var github = new Shared.GitHubApi();
            //    this.list.ItemsSource = await github.GetAsync(this.user.Text);
            //};
            #endregion
        }
    }
}
