using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NetworkToolLibrary
{
    public class Vlan
    {
        public uint minId = 1; 
        public uint maxId =4094;
        public uint Id { get; set; }
        public string Description { get; set; } = "";
        public Vlan(uint id, string description ="")
        {
            
            Id = ValidateVlanId(id);
            Description = description;
        }

        public static bool addToVlan(string text, List<Vlan>vlans)
        {
            uint result;
            if (uint.TryParse(text, out result))
            {
                Vlan vlan = new Vlan(result);
                vlans.Add(vlan);
                return true;
            }
                return false;
            
        }

        private uint ValidateVlanId(uint id)
        {
            uint result;

            if (id > maxId)
            {
                result = maxId;
            }
            else if (id < minId) { 
                result = minId;
            }else
            {
                result = id;
            }

            return result;
        }
    }
}
