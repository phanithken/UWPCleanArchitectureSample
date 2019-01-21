using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Data.Home;
using UWPCleanArchitecture.Classes.Presentation.Scences.Home.Router;

namespace UWPCleanArchitecture.Classes.Presentation.Scences.Home.View {
    public class HomePresenter {

        private HomeRepository repo;
        private HomeScenceRouter router;

        public HomePresenter(HomeScenceRouter router) {
            this.repo = new HomeRepository();
            this.router = router;
        }

        public string getUserName() {
            return this.repo.getUserName();
        }

        public void goBack() {
            this.router.NavigateBack();
        }

    }
}
