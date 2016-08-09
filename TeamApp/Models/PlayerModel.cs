using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamApp.Models
{
    public class PlayerModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public TeamModel Team { get; set; }
        public virtual ICollection<TeamModel> TeamID { get; set; }
    }
}