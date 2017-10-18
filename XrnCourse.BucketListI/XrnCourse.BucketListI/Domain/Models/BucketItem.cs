using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrnCourse.BucketListI.Domain.Models
{
    public class BucketItem
    {
        public Guid Id { get; set; }
        public string ItemDescription { get; set; }
        public int Order { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
