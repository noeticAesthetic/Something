using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Something.Models
{
    [Bind]
    public class EmailModel
    {
        //public string To { get; set; }
        //public string Subject { get; set; }

        [StringLength(50), Required(ErrorMessage="This field is required.")]
        public string From { get; set; }

        [StringLength(500), Required(ErrorMessage = "This field is required.")]
        public string Body { get; set; }

        [StringLength(50), Required(ErrorMessage = "This field is required.")]
        public string FromName { get; set; }

        [Range(1000000000, 9999999999, ErrorMessage="Please enter a ten digit number."), Required(ErrorMessage = "This field is required.")]
        public string FromPhone { get; set; }

        [StringLength(75)]
        public string FromUrl { get; set; }
    }
}