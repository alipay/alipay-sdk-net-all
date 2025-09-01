using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentCommercialCollectioncontentInfoCreateResponse.
    /// </summary>
    public class AlipayContentCommercialCollectioncontentInfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 短带长内容创建成功，返回的操作成功的内容ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
