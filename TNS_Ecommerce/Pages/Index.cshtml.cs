﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;


using TNS_Ecommerce.Models;

namespace TNS_Ecommerce.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string DepartmentKey { get; set; }
        public string DepartmentName { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CheckAuth();
            DepartmentKey = _UserLogin.Employee.DepartmentKey;
            DepartmentName = _UserLogin.Employee.DepartmentName;
            //TaskReport = new Models.Task_Status(DateTime.Now.Month,DateTime.Now.Year,_UserLogin.EmployeeKey);
        }

        #region [ Security ]
        private TNS.Auth.UserLogin_Info _UserLogin;
        private void CheckAuth()
        {
            _UserLogin = new TNS.Auth.UserLogin_Info(User);
        }
		#endregion
		
	}

}
