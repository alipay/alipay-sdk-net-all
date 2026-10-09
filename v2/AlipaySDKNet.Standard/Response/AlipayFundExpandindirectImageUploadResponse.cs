using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundExpandindirectImageUploadResponse.
    /// </summary>
    public class AlipayFundExpandindirectImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件在平台上传的标识，比如oss的key
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
