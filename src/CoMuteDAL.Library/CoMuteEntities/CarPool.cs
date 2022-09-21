﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMuteDAL.Library.CoMuteEntities
{
    public class CarPool
    {
        public int Id { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ExpectedArrivalTime { get; set; }
        public string Origin { get; set; }
        public int DaysAvailable { get; set; }
        public string Destination { get; set; }
        public int AvailableSeats { get; set; }
        public string Notes { get; set; }
    }
}
