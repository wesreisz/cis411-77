using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class AddressModel
    {
        [DisplayName("Input Address to Display")]
        public string InputAddress { get; set; }
        public string DisplayAddress { get; set; }
    }
}