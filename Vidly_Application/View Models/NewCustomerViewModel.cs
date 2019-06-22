using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Application.Models;

namespace Vidly_Application.View_Models
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes{ get; set; }
        public Customer customer { get; set; }
        public string Title
        {
            get
            {
                if (customer != null && customer.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }
    }
}