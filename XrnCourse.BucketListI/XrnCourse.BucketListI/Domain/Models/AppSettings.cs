﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrnCourse.BucketListI.Domain.Models
{
    public class AppSettings
    {
        public Guid CurrentUserId { get; set; }
        public bool EnableListSharing { get; set; }
        public bool EnableNotifications { get; set; }

    }
}
