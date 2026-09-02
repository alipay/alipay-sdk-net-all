using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileItem Data Structure.
    /// </summary>
    [Serializable]
    public class FileItem : AopObject
    {
        /// <summary>
        /// afts 文件 id
        /// </summary>
        [XmlElement("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 文件类型（IMAGE 图片 / VIDEO 视频 / FILE 通用文件）
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
