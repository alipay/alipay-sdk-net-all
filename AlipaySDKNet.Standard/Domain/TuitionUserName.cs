using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionUserName Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionUserName : AopObject
    {
        /// <summary>
        /// 姓名姓氏
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 完整姓名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 姓名最后的名字
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 姓名中间的名字
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }
    }
}
