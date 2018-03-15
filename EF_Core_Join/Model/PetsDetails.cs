using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Join.Model
{
    public class PetsDetails
    {
        /// <summary>
        /// 宠物名称
        /// </summary>
        public string PetName { get; set; }
        /// <summary>
        /// 主人名称
        /// </summary>
        public string OwnerName { get; set; }
    }
}
