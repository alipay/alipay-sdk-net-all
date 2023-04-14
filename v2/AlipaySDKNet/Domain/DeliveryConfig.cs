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
        /// 活动id。 通过商家券相关接口创建的活动。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT
        /// </summary>
        [XmlElement("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识. 说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。 例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
