using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TargetSendOrderParam Data Structure.
    /// </summary>
    [Serializable]
    public class TargetSendOrderParam : AopObject
    {
        /// <summary>
        /// 主单据号
        /// </summary>
        [XmlElement("camp_order_id")]
        public string CampOrderId { get; set; }

        /// <summary>
        /// 证券营销活动id
        /// </summary>
        [XmlElement("interest_id")]
        public string InterestId { get; set; }

        /// <summary>
        /// 发奖单据号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }
    }
}
