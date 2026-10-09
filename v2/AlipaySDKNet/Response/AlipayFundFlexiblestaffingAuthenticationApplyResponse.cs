using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthenticationApplyResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingAuthenticationApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权跳转链接，具体内容类型根据authorize_link_type识别
        /// </summary>
        [XmlElement("apply_link")]
        public string ApplyLink { get; set; }

        /// <summary>
        /// 申请的流程实例ID，注意：同outBizNo也会申请到不同的流程实例
        /// </summary>
        [XmlElement("flow_token")]
        public string FlowToken { get; set; }
    }
}
