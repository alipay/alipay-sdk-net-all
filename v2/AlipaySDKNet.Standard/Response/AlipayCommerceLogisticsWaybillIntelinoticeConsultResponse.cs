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
    }
}
