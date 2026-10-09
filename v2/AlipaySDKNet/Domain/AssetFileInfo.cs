using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetFileInfo : AopObject
    {
        /// <summary>
        /// 物料的文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 物料生产资料的文件链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
