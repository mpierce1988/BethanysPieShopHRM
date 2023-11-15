using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace BethanysPieShop.WebFrontEnd.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; } = default!;

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
            base.OnParametersSet();
        }

        public void Close()
        {
            _employee = null;
        }
    }
}