//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiveChat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {    
        public int iduser { get; set; }
        [Required (ErrorMessage ="This field is required!")]

        [DisplayName("Username")]
        public string userName { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required!")]
        public string userpassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}