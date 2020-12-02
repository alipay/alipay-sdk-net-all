using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantImageUploadResponse.
    /// </summary>
    public class AlipayMerchantImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片在文件存储平台的标识
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
