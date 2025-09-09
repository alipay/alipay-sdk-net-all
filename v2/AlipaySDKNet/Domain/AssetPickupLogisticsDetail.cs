using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetPickupLogisticsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetPickupLogisticsDetail : AopObject
    {
        /// <summary>
        /// 逆向入库指令
        /// </summary>
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 批次号，用于幂等
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_infos")]
        public LogisticsInfo LogisticsInfos { get; set; }

        /// <summary>
        /// 揽收
        /// </summary>
        [XmlElement("pickup_status")]
        public string PickupStatus { get; set; }
    }
}
