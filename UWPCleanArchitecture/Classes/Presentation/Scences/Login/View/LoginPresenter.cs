using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Data.Login;
using UWPCleanArchitecture.Classes.Presentation.Scences.Login.Router;

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Home.View {
    public class LoginPresenter {

        private LoginScenceRouter router;
        private LoginRepository repo;

        public LoginPresenter(LoginScenceRouter router) {
            this.router = router;
            this.repo = new LoginRepository();
        }

        public void PresentLogin(string username, string password) {
            if (username != "" && password != "") {
                if (this.repo.requestLogin(username, password)) {
                    this.router.NavigateToHome();
                }
            }
        }

    }
}
