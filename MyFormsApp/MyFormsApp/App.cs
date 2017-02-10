using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFormsApp
{
    public class App : Application
    {
        public App()
        {
            #region Via C#
            //var statckLayout = new StackLayout { Padding = 20, Spacing = 20 };
            //var user = new Entry { Placeholder = "User" }; // Caixa de texto
            //var search = new Button { Text = "Search" };
            //var list = new ListView();

            //statckLayout.Children.Add(user);
            //statckLayout.Children.Add(search);
            //statckLayout.Children.Add(list);

            //search.Clicked += async (object sender, EventArgs e) =>
            //{
            //    var github = new Shared.GitHubApi();
            //    var items = await github.GetAsync(user.Text);
            //    list.ItemsSource = items;
            //};

            //// The root page of your application
            //var content = new ContentPage
            //{
            //    Content = statckLayout
            //};

            //MainPage = new NavigationPage(content);
            #endregion

            #region Via Xaml
            MainPage = new NavigationPage(new Views.UIXaml());
            #endregion
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
