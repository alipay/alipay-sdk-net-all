using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoBenefitUseResponse.
    /// </summary>
    public class AlipayInsAutoBenefitUseResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁平台使用记录id
        /// </summary>
        [XmlElement("use_flow_id")]
        public string UseFlowId { get; set; }
    }
}
