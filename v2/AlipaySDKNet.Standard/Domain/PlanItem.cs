using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlanItem Data Structure.
    /// </summary>
    [Serializable]
    public class PlanItem : AopObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [XmlElement("warehouse_id")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [XmlElement("warehouse_name")]
        public string WarehouseName { get; set; }
    }
}
