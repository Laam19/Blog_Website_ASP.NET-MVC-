using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Blog_website_Asp.Net.ViewModels
{
    public class LogInViewModel
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
