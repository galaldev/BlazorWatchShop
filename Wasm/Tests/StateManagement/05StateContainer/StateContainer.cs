using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Tests.StateManagement._05StateContainer
{
    public class StateContainer
    {
        public UserInfo User { get; set; }

        public event Action OnChange;

        public void SetUser(UserInfo user)
        {
            User = user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
