using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingEncodeShortlinkCreateResponse.
    /// </summary>
    public class AlipayMarketingEncodeShortlinkCreateResponse : AopResponse
    {
        /// <summary>
        /// 将长连接改写成短连接，改写成功后的短连接地址
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
