﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    /// <summary>
    /// Base Component for AntContent
    /// </summary>
    public class AntContentComponent : AntBaseComponent
    {
        private string prefixCls = getPrefixCls("layout-content");
        protected override Task OnParametersSetAsync()
        {
            ClassNames.Clear()
               .Add(prefixCls);

            return base.OnParametersSetAsync();
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
