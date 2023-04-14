using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseFileUrlUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseFileUrlUploadModel : AopObject
    {
        /// <summary>
        /// 带后缀文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件下载url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
