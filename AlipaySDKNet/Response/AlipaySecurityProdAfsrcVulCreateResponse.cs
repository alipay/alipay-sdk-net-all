using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulCreateResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulCreateResponse : AopResponse
    {
        /// <summary>
        /// 漏洞创建结果描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 漏洞创建是否成功标识
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
