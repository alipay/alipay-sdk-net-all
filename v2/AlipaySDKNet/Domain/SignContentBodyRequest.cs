using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignContentBodyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SignContentBodyRequest : AopObject
    {
        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlElement("plain_content")]
        public string PlainContent { get; set; }

        /// <summary>
        /// sha1加签后内容，如果没有加签内容则取原始内容加sha1
        /// </summary>
        [XmlElement("sha_content")]
        public string ShaContent { get; set; }
    }
}
