using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdIifaadidBioApplyResponse.
    /// </summary>
    public class AlipaySecurityProdIifaadidBioApplyResponse : AopResponse
    {
        /// <summary>
        /// 响应结果数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
