using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationAttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationAttachmentInfo : AopObject
    {
        /// <summary>
        /// 附件类型
        /// </summary>
        [XmlElement("attachment_type")]
        public string AttachmentType { get; set; }

        /// <summary>
        /// 图片id，需使用图片上传接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 协议失效时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议生效时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
