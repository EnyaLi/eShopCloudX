﻿using System.Threading.Tasks;
using BlazorAdmin.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAdmin.Helpers
{
    public class BlazorLayoutComponent : LayoutComponentBase
    {
        private readonly RefreshBroadcast _refresh = RefreshBroadcast.Instance;

        protected override Task OnInitializedAsync()
        {
            _refresh.RefreshRequested += DoRefresh;
            return base.OnInitializedAsync();
        }

        public void CallRequestRefresh()
        {
            _refresh.CallRequestRefresh();
        }

        private void DoRefresh()
        {
            StateHasChanged();
        }
    }
}