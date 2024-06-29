using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OST_inventory_B_2.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public Member Member { get; set; }

        public Equipment() { 
             Member = new Member();
        }
        public static List<Equipment> ListEquipment()
        {
            List<Equipment> lis = new List<Equipment>();
            for(int i = 1; i < 20; i++)
            {
                Equipment equip = new Equipment();
                equip.EquipmentId = i;
                equip.Name = "Laptop "+i.ToString();
                equip.Quantity = i*3;
                equip.EntryDate = DateTime.Now.Date;


                equip.Member.MemberId = i;
                equip.Member.MemberName = "Member "+i.ToString();
                equip.Member.MemberDesig = "Designation "+i.ToString();
                equip.Member.Memberaddress = "Mirpur "+i.ToString();
                equip.Member.MemberContact = "01765432898"+i.ToString();
                equip.Member.EntryDate = DateTime.Now.Date;
                lis.Add(equip);
            }
            

           

            return lis; 
        }
    }
}