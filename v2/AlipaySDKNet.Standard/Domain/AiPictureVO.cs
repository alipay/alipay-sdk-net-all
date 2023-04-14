using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AiPictureVO Data Structure.
    /// </summary>
    [Serializable]
    public class AiPictureVO : AopObject
    {
        /// <summary>
        /// 图片ID
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 安全状态
        /// </summary>
        [XmlElement("sec_status")]
        public string SecStatus { get; set; }
    }
}
