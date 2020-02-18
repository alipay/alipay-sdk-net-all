using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingMaterialImageUploadResponse.
    /// </summary>
    public class AlipayMarketingMaterialImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
