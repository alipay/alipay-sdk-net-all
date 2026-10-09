using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSyncModel : AopObject
    {
        /// <summary>
        /// 发货事件唯一标识
        /// </summary>
        [XmlElement("delivery_sync_event_id")]
        public string DeliverySyncEventId { get; set; }

        /// <summary>
        /// 发货时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 总代订单号
        /// </summary>
        [XmlElement("general_agency_order_no")]
        public string GeneralAgencyOrderNo { get; set; }

        /// <summary>
        /// 报价单号
        /// </summary>
        [XmlElement("quotation_no")]
        public string QuotationNo { get; set; }
    }
}
