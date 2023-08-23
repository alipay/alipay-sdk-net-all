using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudDevopsDictQueryResponse.
    /// </summary>
    public class AlipayCloudDevopsDictQueryResponse : AopResponse
    {
        /// <summary>
        /// 配置属性
        /// </summary>
        [XmlElement("config")]
        public string Config { get; set; }
    }
}
