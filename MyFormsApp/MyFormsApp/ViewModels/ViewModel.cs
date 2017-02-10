using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFormsApp.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        private string user;
        public string User
        {
            get { return this.user; }
            set
            {
                this.user = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(User)));
            }
        }

        private List<string> items;
        public List<string> Items
        {
            get { return this.items; }
            set
            {
                this.items = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
            }
        }

        public ICommand Clicked { get; set; }

        public ViewModel()
        {
            this.Clicked = new Command(async () =>
            {
                var github = new Shared.GitHubApi();
                Items = await github.GetAsync(this.User);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
