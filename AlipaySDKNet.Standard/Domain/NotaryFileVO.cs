using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NotaryFileVO Data Structure.
    /// </summary>
    [Serializable]
    public class NotaryFileVO : AopObject
    {
        /// <summary>
        /// 文件http地址
        /// </summary>
        [XmlElement("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
