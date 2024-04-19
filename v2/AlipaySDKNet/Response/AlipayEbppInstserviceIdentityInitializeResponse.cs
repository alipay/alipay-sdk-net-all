using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceIdentityInitializeResponse.
    /// </summary>
    public class AlipayEbppInstserviceIdentityInitializeResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 核身字符串
        /// </summary>
        [XmlElement("verify_id")]
        public string VerifyId { get; set; }
    }
}
