using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseFileUrlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseFileUrlGetModel : AopObject
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 上传文件编码格式
        /// </summary>
        [XmlElement("source_format")]
        public string SourceFormat { get; set; }

        /// <summary>
        /// 目标转换文件编码格式
        /// </summary>
        [XmlElement("target_format")]
        public string TargetFormat { get; set; }
    }
}
