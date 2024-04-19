using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIcpStatusQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIcpStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 如果备案状态为驳回时，比如SECURITY_AUDIT_REJECT SUPERVISION_AUDIT_REJECT，展示的是驳回的原因；如果不是驳回状态则展示其他状态的提示信息
        /// </summary>
        [XmlElement("icp_result_desc")]
        public string IcpResultDesc { get; set; }

        /// <summary>
        /// 小程序备案结果状态
        /// </summary>
        [XmlElement("icp_status")]
        public string IcpStatus { get; set; }
    }
}
