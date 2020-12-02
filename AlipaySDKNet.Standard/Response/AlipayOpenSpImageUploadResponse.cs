using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpImageUploadResponse.
    /// </summary>
    public class AlipayOpenSpImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 图片在文件存储平台的标识
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
