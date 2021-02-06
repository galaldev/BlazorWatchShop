using System;
using Microsoft.AspNetCore.Components;

namespace WatchShop.Tests.StateManagement._08StateContainerBaseComponentDontRenderParent
{
    public class StateContainer
    {
        public UserInfo User { get; set; }

        public event Action<ComponentBase> OnChange;

        public void SetUser(UserInfo user,ComponentBase source)
        {
            User = user;
            NotifyStateChanged(source);
        }

        private void NotifyStateChanged(ComponentBase source) => OnChange?.Invoke(source);
    }
}
