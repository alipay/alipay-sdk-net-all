using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CoreMaterialStockData Data Structure.
    /// </summary>
    [Serializable]
    public class CoreMaterialStockData : AopObject
    {
        /// <summary>
        /// 实际库存数量,单位是个
        /// </summary>
        [XmlElement("actual_count")]
        public long ActualCount { get; set; }

        /// <summary>
        /// 核心原材料ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 核心原材料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 用于存储库存的记录日期
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 在途库存数量，单位是个
        /// </summary>
        [XmlElement("transferring_count")]
        public long TransferringCount { get; set; }

        /// <summary>
        /// 仓库ID
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
