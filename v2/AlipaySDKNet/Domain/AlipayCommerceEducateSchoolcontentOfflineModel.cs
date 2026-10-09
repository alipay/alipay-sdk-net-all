using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcontentOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolcontentOfflineModel : AopObject
    {
        /// <summary>
        /// 支付宝返回的内容唯一ID
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }
    }
}
