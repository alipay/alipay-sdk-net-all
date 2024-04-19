using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityCommonQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 无
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功/失败code
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
