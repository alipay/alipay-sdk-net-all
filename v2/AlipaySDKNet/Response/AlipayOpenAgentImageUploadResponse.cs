using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentImageUploadResponse.
    /// </summary>
    public class AlipayOpenAgentImageUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传图片返回的图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }
    }
}
