using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PurchaseSQLDB.DataAccess.EFClasses;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.DTO
{
    public class EmployeeListDto
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public bool IsPurchaser { get; set; }
        public string Email { get; set; }
       
       
    }
}
