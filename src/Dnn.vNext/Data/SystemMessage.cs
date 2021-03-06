﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class SystemMessage
    {
        [Key]
/*PK*/  public int MessageId { get; set; }
/*FK*/  public int? PortalId { get; set; }
        public string MessageName { get; set; }
        public string MessageValue { get; set; }

        public virtual Portal Portal { get; set; }
    }
}
