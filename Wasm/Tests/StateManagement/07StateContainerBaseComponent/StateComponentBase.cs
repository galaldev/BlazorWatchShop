using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WatchShop.Tests.StateManagement._07StateContainerBaseComponent
{
    public class StateComponentBase: ComponentBase,IDisposable
    {
        [Inject]
        protected StateContainer StateContainer { get; set; }

        protected override void OnInitialized()
        {
            StateContainer.OnChange += StateHasChanged;
            base.OnInitialized();
        }

        public void Dispose()
        {
            StateContainer.OnChange -= StateHasChanged;
        }
    }
}
