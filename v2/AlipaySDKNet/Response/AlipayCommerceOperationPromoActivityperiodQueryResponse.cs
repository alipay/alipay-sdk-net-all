using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoActivityperiodQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoActivityperiodQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前在途活动
        /// </summary>
        [XmlElement("current_activity")]
        public ActivityPeriodInfo CurrentActivity { get; set; }

        /// <summary>
        /// 下一期活动
        /// </summary>
        [XmlElement("next_activity")]
        public ActivityPeriodInfo NextActivity { get; set; }
    }
}
