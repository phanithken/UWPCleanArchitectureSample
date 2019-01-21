using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Home.Router {
    public class HomeScenceRouter {

        private HomeScence home;

        public HomeScenceRouter(HomeScence home) {
            this.home = home;
        }

        public void NavigateBack() {
            this.home.Frame.GoBack();
        }

    }
}
