using System;

namespace WatchShop.Tests.StateManagement._06StateContainerCustomProperties
{
    public class StateContainer
    {
        private string _name;
        private string _email;

        public string Name
        {
            get => _name;
            set { _name = value; NotifyStateChanged(); }
        }

        public string Email
        {
            get => _email;
            set { _email = value; NotifyStateChanged(); }
        }

        public event Action OnChange;



        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
