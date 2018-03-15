using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Join.Model
{
    /// <summary>
    /// 宠物类
    /// </summary>
    public class Pet
    {
        public int Id { get; set; }
        /// <summary>
        /// 主人Id
        /// </summary>
        public int Owner { get; set; }
        /// <summary>
        /// 宠物名称
        /// </summary>
        public string Name { get; set; }
    }
}
