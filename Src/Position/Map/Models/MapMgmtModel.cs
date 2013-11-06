﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Models
{
    public class MapMgmtModel
    {
        public List<MonitorPoint> MonitorList { get; set; }

        public MapMgmtModel() {
            MonitorList = new List<MonitorPoint>();
        }
    }
}