﻿using System;
using BethanysPieShop.WebFrontEnd.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShop.WebFrontEnd.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
            base.OnInitialized();
        }
    }
}

