using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcontentModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateSchoolcontentModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝返回的内容唯一Id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
