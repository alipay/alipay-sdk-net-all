using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberCompletegcwtaskModifyResponse.
    /// </summary>
    public class AlipayUserMemberCompletegcwtaskModifyResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// true推进任务成功，false推进任务失败，需要重试
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
