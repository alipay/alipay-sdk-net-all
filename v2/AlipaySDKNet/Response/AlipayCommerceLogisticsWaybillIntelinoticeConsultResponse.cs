using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIntelinoticeConsultResponse.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillIntelinoticeConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否能支持智能通知
        /// </summary>
        [XmlElement("can_intelinotice")]
        public bool CanIntelinotice { get; set; }

        /// <summary>
        /// 发送短信手机号后四位
        /// </summary>
        [XmlElement("sms_number")]
        public string SmsNumber { get; set; }
    }
}
