using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsOpenAttachmentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsOpenAttachmentDTO : AopObject
    {
        /// <summary>
        /// afts的id
        /// </summary>
        [XmlElement("afts_file_id")]
        public string AftsFileId { get; set; }

        /// <summary>
        /// 基础业务数据
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 附件类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
