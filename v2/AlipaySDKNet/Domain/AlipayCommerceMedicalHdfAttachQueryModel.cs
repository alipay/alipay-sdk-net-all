using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfAttachQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfAttachQueryModel : AopObject
    {
        /// <summary>
        /// 附件ID
        /// </summary>
        [XmlElement("attachment_id")]
        public string AttachmentId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 超时时间ms
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 高度px
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 图片格式：jpg、jpeg、png、gif、bmp、webp、tiff、svg、ico、avif、heic等
        /// </summary>
        [XmlElement("img_format")]
        public string ImgFormat { get; set; }

        /// <summary>
        /// 宽度px
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
