using System;

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

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
