using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class tbl_User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNo { get; set; }
        public string? Address { get; set; }
        public string? Pin { get; set; }
        public int? CountryID { get; set; }
        public int? StateID { get; set; }
        public int? CityID { get; set; }
        public string? Email { get; set; }
        public string? RefreshToken {  get; set; }
        public string? RefreshTokenExpiry {  get; set; }
        public string? RoleID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActivate { get; set; }
        public DateTime DeactivatedDateTime { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? DOB { get; set; }
        public bool IsEmailVerified { get; set; }


    }
}
