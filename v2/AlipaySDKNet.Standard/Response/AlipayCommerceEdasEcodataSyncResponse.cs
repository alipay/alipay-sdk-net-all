using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEdasEcodataSyncResponse.
    /// </summary>
    public class AlipayCommerceEdasEcodataSyncResponse : AopResponse
    {
        /// <summary>
        /// 创建的数据内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
