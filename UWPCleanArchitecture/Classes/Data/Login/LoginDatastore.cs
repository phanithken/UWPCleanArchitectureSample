using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPCleanArchitecture.Classes.Data.Model;

namespace UWPCleanArchitecture.Classes.Data.Login {
    public class LoginDatastore {

        public bool save(string username, string password) {
            var config = RealmConfiguration.DefaultConfiguration;
            config.SchemaVersion = 1;
            var realm = Realm.GetInstance(config);
            realm.Write(() => {
                var user = new UserModel();
                user.Id = 1;
                user.Username = username;
                user.Password = password;
                realm.Add(user, update: true);
            });
            return true;
        }

        public void delete(string username) {
            var config = RealmConfiguration.DefaultConfiguration;
            config.SchemaVersion = 1;
            var realm = Realm.GetInstance(config);
            var users = realm.All<UserModel>().First(u => u.Username == username);

            using (var trans = realm.BeginWrite()) {
                realm.Remove(users);
                trans.Commit();
            }
        }

        public void migration() {
            var config = RealmConfiguration.DefaultConfiguration;
            config.SchemaVersion = 1;
        }

    }
}
