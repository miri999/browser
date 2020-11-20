using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Browser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Uri ta1 = new Uri("https://www.google.com", UriKind.Absolute);
        Uri ta2;
        Uri ta3;
        Uri ta4;
        Uri to;
        int tab = 0;
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void t4(object sender, RoutedEventArgs e)
        {
            tt4.IsEnabled = false;
            tt3.IsEnabled = true;
            tt2.IsEnabled = true;
            tt1.IsEnabled = true;

            tt1.IsChecked = false;
            tt2.IsChecked = false;
            tt3.IsChecked = false;
            tt4.IsChecked = false;
            tab = 3;
            if (ta2 == null) return;
            web.Navigate(ta4);
        }

        private void t3(object sender, RoutedEventArgs e)
        {
            tt4.IsEnabled = true;
            tt3.IsEnabled = false;
            tt2.IsEnabled = true;
            tt1.IsEnabled = true;

            tt1.IsChecked = false;
            tt2.IsChecked = false;
            tt3.IsChecked = false;
            tt4.IsChecked = false;
            tab = 2;
            if (ta3 == null) return;
            web.Navigate(ta3);
        }

        private void t2(object sender, RoutedEventArgs e)
        {
            tt4.IsEnabled = true;
            tt3.IsEnabled = true;
            tt2.IsEnabled = false;
            tt1.IsEnabled = true;

            tt1.IsChecked = false;
            tt2.IsChecked = false;
            tt3.IsChecked = false;
            tt4.IsChecked = false;
            tab = 1;
            if (ta2 == null) return;
            web.Navigate(ta2);
        }

        private void t1(object sender, RoutedEventArgs e)
        {
            tt4.IsEnabled = true;
            tt3.IsEnabled = true;
            tt2.IsEnabled = true;
            tt1.IsEnabled = false;

            tt1.IsChecked = false;
            tt2.IsChecked = false;
            tt3.IsChecked = false;
            tt4.IsChecked = false;
            web.Navigate(ta1);
            tab = 0;
        }

        private void go(object sender, RoutedEventArgs e)
        {
            to = new Uri("https://www.google.com/search?q="+search.Text.Trim(), UriKind.Absolute);
            url.Text = to.ToString();
            web.Navigate(to);
            if (tab == 0)
            {
                ta1 = to;
            }
            else if (tab == 1)
            {
                ta2 = to;
            }
            else if (tab == 2)
            {
                ta3 = to;
            }
            else if (tab == 3)
            {
                ta4 = to;
            }
        }

        private void goTo(object sender, RoutedEventArgs e)
        {
            to = new Uri(url.Text.Trim(), UriKind.Absolute);
            web.Navigate(to);
            if(tab == 0)
            {
                ta1 = to;
            }else if (tab==1)
            {
                ta2 = to;
            }
            else if (tab == 2)
            {
                ta3 = to;
            }
            else if (tab == 3)
            {
                ta4 = to;
            }
        }

        private void reload(object sender, RoutedEventArgs e)
        {
            web.Refresh();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            if (!web.CanGoBack) return;
            web.GoBack();
        }

        private void forward(object sender, RoutedEventArgs e)
        {
            if (!web.CanGoForward) return;
            web.GoForward();
        }
    }
}
