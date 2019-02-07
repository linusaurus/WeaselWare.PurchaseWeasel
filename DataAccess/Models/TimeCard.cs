using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;



namespace PurchaseSQLDB.DataAccess.EFClasses
{
    public class TimeCard
    {

        [Key]
        public int timecard_id { get; set; }
        public int job_id { get; set; }
        public double total_hr { get; set; }
    }
}
