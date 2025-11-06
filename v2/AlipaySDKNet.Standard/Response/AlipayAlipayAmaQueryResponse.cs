using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAlipayAmaQueryResponse.
    /// </summary>
    public class AlipayAlipayAmaQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回文本内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 流式结束
        /// </summary>
        [XmlElement("finished")]
        public bool Finished { get; set; }
    }
}
