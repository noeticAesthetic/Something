using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Something.Models
{
    [Bind]
    public class RecommendedModel
    {
        [StringLength(50), Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        private const string _TOKEN = "pass";
        public string Token { get { return _TOKEN; } }
    }
}