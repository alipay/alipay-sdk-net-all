using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingImageEnhanceUploadResponse.
    /// </summary>
    public class AlipayMarketingImageEnhanceUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片是否优化过。若上传选择需要优化，且上传的图片不符合规范，会对图片进行优化。
        /// </summary>
        [XmlElement("image_enhanced")]
        public bool ImageEnhanced { get; set; }

        /// <summary>
        /// 图片唯一资源ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 图索引id。图片在相册中的索引id。
        /// </summary>
        [XmlElement("image_index_id")]
        public string ImageIndexId { get; set; }

        /// <summary>
        /// 图片上传后返回的链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }
    }
}
