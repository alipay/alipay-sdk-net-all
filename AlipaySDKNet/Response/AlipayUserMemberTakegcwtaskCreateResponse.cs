using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberTakegcwtaskCreateResponse.
    /// </summary>
    public class AlipayUserMemberTakegcwtaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 任务流水id，唯一值，用于双方幂等控制
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// true领取成功，false领取失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
