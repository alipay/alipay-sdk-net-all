using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractFileVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractFileVO : AopObject
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
