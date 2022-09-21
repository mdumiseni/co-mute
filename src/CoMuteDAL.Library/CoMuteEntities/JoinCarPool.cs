using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMuteDAL.Library.CoMuteEntities
{
    public class JoinCarPool
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarPoolId { get; set; }
        public DateTime JoiningDate { get; set; }

        public bool StillIn { get; set; }

        public CarPool CarPool { get; set; }
        public User User { get; set; }
    }
}
