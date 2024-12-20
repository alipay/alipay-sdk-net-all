using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdTaskCloseResponse.
    /// </summary>
    public class AlipayCommerceWithholdTaskCloseResponse : AopResponse
    {
        /// <summary>
        /// 代扣任务ID
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }
    }
}
