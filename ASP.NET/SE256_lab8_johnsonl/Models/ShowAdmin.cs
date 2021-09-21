using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using SE256_lab5_johnsonl.Models;

using System.Data;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace SE256_lab5_johnsonl.Models
{
    public class ShowAdmin
    {
        [Required]
        public int ShowAdminID { get; set; }

        [EmailAddress]
        [Display(Name = "Username")]
        public String ShowAdminEmail { get; set; }

        [Required, StringLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String ShowAdminPW { get; set;}

        public String Feedback { get; set; }

    }
}
