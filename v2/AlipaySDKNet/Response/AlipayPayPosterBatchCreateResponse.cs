using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayPosterBatchCreateResponse.
    /// </summary>
    public class AlipayPayPosterBatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的主键
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
