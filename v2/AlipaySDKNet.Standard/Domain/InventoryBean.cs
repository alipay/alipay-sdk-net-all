using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InventoryBean Data Structure.
    /// </summary>
    [Serializable]
    public class InventoryBean : AopObject
    {
        /// <summary>
        /// 库存总额，单位：个/份
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 库存ID
        /// </summary>
        [XmlElement("inventory_id")]
        public string InventoryId { get; set; }

        /// <summary>
        /// 库存余额，单位：个/份
        /// </summary>
        [XmlElement("inventory_remain")]
        public long InventoryRemain { get; set; }
    }
}
