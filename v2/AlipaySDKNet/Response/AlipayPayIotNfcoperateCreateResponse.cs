using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayIotNfcoperateCreateResponse.
    /// </summary>
    public class AlipayPayIotNfcoperateCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成活动主键
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }
    }
}
