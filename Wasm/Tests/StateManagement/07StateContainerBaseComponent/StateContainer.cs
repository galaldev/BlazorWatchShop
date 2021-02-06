using System;

namespace WatchShop.Tests.StateManagement._07StateContainerBaseComponent
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
