using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandWarehouseOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandWarehouseOrderSyncModel : AopObject
    {
        /// <summary>
        /// 配送指令ID
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [XmlElement("new_warehouse_id")]
        public string NewWarehouseId { get; set; }

        /// <summary>
        /// 指令类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
