using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIotfmPlugaddrQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalIotfmPlugaddrQueryResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 插件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
