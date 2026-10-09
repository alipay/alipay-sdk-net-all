using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteDomaincertQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteDomaincertQueryResponse : AopResponse
    {
        /// <summary>
        /// 证书，PEM格式
        /// </summary>
        [XmlElement("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// 是否开启https
        /// </summary>
        [XmlElement("enable_https")]
        public bool EnableHttps { get; set; }
    }
}
