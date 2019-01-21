using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPCleanArchitecture.Classes.Data.Login {
    public class LoginRepository {

        private LoginDatastore store;

        public LoginRepository() {
            this.store = new LoginDatastore();
        }

        public bool requestLogin(string username, string password) {
            return this.store.save(username, password);
            //this.store.migration();
            //this.store.delete(username);
            //return true;
        }

    }
}
