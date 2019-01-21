using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPCleanArchitecture.Classes.Presentation.Scences.Home.Router;
using UWPCleanArchitecture.Classes.Presentation.Scences.Home.View;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Home {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeScence : Page {

        private HomePresenter presenter;
        private HomeScenceRouter router;

        public HomeScence() {
            this.InitializeComponent();
            this.router = new HomeScenceRouter(this);
            this.presenter = new HomePresenter(router);
            this.setName();
        }

        void goBack(object sender, RoutedEventArgs e) {
            this.presenter.goBack();
        }

        private void setName() {
            greet.Text = "Hello " + this.presenter.getUserName();
        }
    }
}
