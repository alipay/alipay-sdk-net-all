using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthCreateResponse.
    /// </summary>
    public class AlipaySecurityRiskHufuAuthCreateResponse : AopResponse
    {
        /// <summary>
        /// 额外信息
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

        /// <summary>
        /// 调用应用传入的serial
        /// </summary>
        [XmlElement("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// 虎符创建成功的token，有效时间3分钟
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
