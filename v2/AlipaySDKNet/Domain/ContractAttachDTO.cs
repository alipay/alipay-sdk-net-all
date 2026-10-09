using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractAttachDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractAttachDTO : AopObject
    {
        /// <summary>
        /// filekey
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
