using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New.Entity;
using New.RestUtility;

namespace New.Service
{
    public class UserService
    {
        public const string GetUserListUrl = "/user/list";
        public const string AuthenticationResourceUrl = "/user/authentication";


        public ObservableCollection<User> GetUserList(List<KeyValuePair<string, string>> conditions = null)
        {
            return RestHelper.Get<ObservableCollection<User>>(GetUserListUrl, conditions);
        }


        public User Authentication(User user)
        {
            return RestHelper.Post(AuthenticationResourceUrl, user);
        }

    }
}
