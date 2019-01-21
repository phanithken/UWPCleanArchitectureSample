using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Presentation.Scences.Login;

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Main.Router {
    class MainScenceRouter {

        private MainPage mainPage;

        public MainScenceRouter(MainPage mainPage) {
            this.mainPage = mainPage;
        }

        public void NavigateToLogin() {
            this.mainPage.Frame.Navigate(typeof(LoginScence));
        }
    }
}
