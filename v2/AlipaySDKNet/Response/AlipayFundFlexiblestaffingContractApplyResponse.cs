using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingContractApplyResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingContractApplyResponse : AopResponse
    {
        /// <summary>
        /// 签约跳转链接
        /// </summary>
        [XmlElement("apply_link")]
        public string ApplyLink { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [XmlElement("flow_token")]
        public string FlowToken { get; set; }
    }
}
