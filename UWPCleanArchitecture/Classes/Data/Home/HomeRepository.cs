using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPCleanArchitecture.Classes.Data.Home {
    public class HomeRepository {

        private HomeDatastore store;

        public HomeRepository() {
            this.store = new HomeDatastore();
        }

        public string getUserName() {
            return this.store.getUsername();
        }

    }
}
