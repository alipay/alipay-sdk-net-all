using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseHttpaccessCnameGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseHttpaccessCnameGetResponse : AopResponse
    {
        /// <summary>
        /// 自定义域名CNAME目标地址
        /// </summary>
        [XmlElement("cname")]
        public string Cname { get; set; }
    }
}
