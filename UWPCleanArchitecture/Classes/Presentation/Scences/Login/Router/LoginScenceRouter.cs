using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Presentation.Scences.Home;

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Login.Router {

    public class LoginScenceRouter {

        private LoginScence loginScence;

        public LoginScenceRouter(LoginScence loginScence) {
            this.loginScence = loginScence;
        }

        public void NavigateToHome() {
            this.loginScence.Frame.Navigate(typeof(HomeScence));
        }
    }
}
