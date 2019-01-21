using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPCleanArchitecture.Classes.Presentation.Scences.Home.View;
using UWPCleanArchitecture.Classes.Presentation.Scences.Login.Router;
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

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Login {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginScence : Page {

        private LoginPresenter presenter;
        private LoginScenceRouter router;

        public LoginScence() {
            this.InitializeComponent();
            this.router = new LoginScenceRouter(this);
            this.presenter = new LoginPresenter(router);
        }

        void Login(object send, RoutedEventArgs e) {
            this.presenter.PresentLogin(username.Text, password.Password.ToString());
        }
    }
}
