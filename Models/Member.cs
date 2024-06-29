using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OST_inventory_B_2.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberDesig { get; set; }
        public string MemberContact { get; set; }
        public string Memberaddress { get; set; }
        public DateTime EntryDate { get; set; }
    }
}