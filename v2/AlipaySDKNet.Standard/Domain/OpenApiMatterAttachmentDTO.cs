using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiMatterAttachmentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiMatterAttachmentDTO : AopObject
    {
        /// <summary>
        /// 事项附件编码
        /// </summary>
        [XmlElement("attachment_code")]
        public string AttachmentCode { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// oss路径
        /// </summary>
        [XmlElement("attachment_path")]
        public string AttachmentPath { get; set; }

        /// <summary>
        /// 附件下载http链接
        /// </summary>
        [XmlElement("attachment_url")]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 事项编码
        /// </summary>
        [XmlElement("matter_code")]
        public string MatterCode { get; set; }
    }
}
