using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApii.Models
{
    /// <summary>
    /// CustomerDesign Response Model
    /// </summary>
    public class CustomerDesignResponseModel
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public IEnumerable<Designs> Designs { get; set; }
    }

    /// <summary>
    /// Customer
    /// </summary>
    public class Customer
    {
        public string Customerid;
        public string Name;
        public string Email;
        public string PrimaryPhone;
        public string SecondaryPhone;
        public string Address;
    }

    /// <summary>
    /// Store
    /// </summary>
    public class Store
    {
        public string Associate;
        public string StoreNumber;
        public string StoreAddress;
        public string StorePhone;
    }

    /// <summary>
    /// Designs
    /// </summary>
    public class Designs
    {
        public string DesignID;
        public string AgreementNumber;
    }
}