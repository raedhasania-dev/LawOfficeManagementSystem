using System;
using System.Collections.Generic;
using System.Linq;
namespace LawOfficeManagementSystem.Models {
    public class Client {
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IDNumber { get; set; }
        public string JobTitle { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
    }
}