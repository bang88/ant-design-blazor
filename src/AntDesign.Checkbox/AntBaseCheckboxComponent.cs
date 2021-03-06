﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace AntDesign
{

    /// <summary>
    /// Base Component for AntBaseCheckbox
    /// </summary>
    public class AntBaseCheckboxComponent : AntCheckboxParameters
    {

        protected override Task OnParametersSetAsync()
        {
            ClassNames.Clear()
               .Add(prefixCls)
               .Add($"{prefixCls}-checked", () => Checked.GetValueOrDefault())
               .Add($"{prefixCls}-disabled", () => disabled)
               ;

            return base.OnParametersSetAsync();
        }
        [Parameter]
        public string prefixCls { get; set; } = "rc-checkbox";

        protected void OnChangeHandler(UIChangeEventArgs ev)
        {
            if (disabled)
            {
                return;
            }
            if (this.Checked == null)
            {
                bool _checked;
                bool.TryParse(ev.Value.ToString(), out _checked);
                Checked = _checked;
            }
            OnChange.InvokeAsync(ev);
        }

    }
}
