using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingEmployeehomeApplyResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingEmployeehomeApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权跳转链接
        /// </summary>
        [XmlElement("apply_link")]
        public string ApplyLink { get; set; }

        /// <summary>
        /// 跳转链接类型
        /// </summary>
        [XmlElement("apply_link_type")]
        public string ApplyLinkType { get; set; }

        /// <summary>
        /// 唯一标识token
        /// </summary>
        [XmlElement("flow_token")]
        public string FlowToken { get; set; }
    }
}
