using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 4--已上线 5--已失效(下线) 6--上线失败
        /// </summary>
        [XmlElement("status_code")]
        public long StatusCode { get; set; }
    }
}
