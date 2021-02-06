using System;
using Microsoft.AspNetCore.Components;

namespace WatchShop.Tests.StateManagement._08StateContainerBaseComponentDontRenderParent
{
    public class StateComponentBase: ComponentBase,IDisposable
    {
        [Inject]
        protected StateContainer StateContainer { get; set; }

        protected override void OnInitialized()
        {
            StateContainer.OnChange += ChangeState;
            base.OnInitialized();
        }

        public void Dispose()
        {
            StateContainer.OnChange -= ChangeState;
        }

        void ChangeState(ComponentBase source)
        {
            if(source!=this)
                StateHasChanged();
        }

    }
}
