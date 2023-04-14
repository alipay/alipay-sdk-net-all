using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainGovernmentQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉工单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }
    }
}
