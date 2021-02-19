using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferUserName Data Structure.
    /// </summary>
    [Serializable]
    public class TransferUserName : AopObject
    {
        /// <summary>
        /// 姓
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 中间名字
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 本地名字
        /// </summary>
        [XmlElement("native_name")]
        public string NativeName { get; set; }
    }
}
