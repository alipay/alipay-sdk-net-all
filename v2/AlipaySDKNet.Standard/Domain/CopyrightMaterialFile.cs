using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CopyrightMaterialFile Data Structure.
    /// </summary>
    [Serializable]
    public class CopyrightMaterialFile : AopObject
    {
        /// <summary>
        /// 授权文件通过上传接口上传后得到的文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 授权文件的名称，用于页面展示
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
