using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantTradecomplainQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantTradecomplainQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [XmlElement("complain_event_id")]
        public string ComplainEventId { get; set; }
    }
}
