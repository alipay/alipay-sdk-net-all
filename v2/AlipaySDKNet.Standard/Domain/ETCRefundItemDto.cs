using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ETCRefundItemDto Data Structure.
    /// </summary>
    [Serializable]
    public class ETCRefundItemDto : AopObject
    {
        /// <summary>
        /// 退款类目
        /// </summary>
        [XmlElement("item_category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// 本项实际退费
        /// </summary>
        [XmlElement("item_refund_amount")]
        public string ItemRefundAmount { get; set; }

        /// <summary>
        /// 外部行程唯一流水号
        /// </summary>
        [XmlElement("out_trip_id")]
        public string OutTripId { get; set; }
    }
}
