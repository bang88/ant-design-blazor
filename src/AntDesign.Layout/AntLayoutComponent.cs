﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    /// <summary>
    /// Base Component for AntLayout
    /// </summary>
    public class AntLayoutComponent : AntBaseComponent
    {
        private string prefixCls = getPrefixCls("layout");
        protected override Task OnParametersSetAsync()
        {
            ClassNames.Clear()
               .Add(prefixCls)
                           .Add($"{prefixCls}-has-sider", () => this.hasSider);
            return base.OnParametersSetAsync();
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool hasSider { get; set; }
    }
}
