using Realms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Data.Model;

namespace UWPCleanArchitecture.Classes.Data.Home {
    public class HomeDatastore {

        public string getUsername() {
            var config = RealmConfiguration.DefaultConfiguration;
            config.SchemaVersion = 1;
            var realm = Realm.GetInstance(config);
            var users = realm.All<UserModel>().First();
            return users.Username;
        }

    }
}
