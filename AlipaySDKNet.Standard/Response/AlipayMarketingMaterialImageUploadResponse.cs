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
        /// 图片是否优化过。系统会根据要求，对上传的图片做尺寸的优化。
        /// </summary>
        [XmlElement("resource_enhance")]
        public bool ResourceEnhance { get; set; }

        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 上传后图片的url地址
        /// </summary>
        [XmlElement("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
