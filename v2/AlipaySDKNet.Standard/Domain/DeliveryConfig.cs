using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryConfig Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryConfig : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT
        /// </summary>
        [XmlElement("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识.
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
