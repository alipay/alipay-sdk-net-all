using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxRefundUserName Data Structure.
    /// </summary>
    [Serializable]
    public class TaxRefundUserName : AopObject
    {
        /// <summary>
        /// 用户的名字
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 用户的姓氏
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 中间名
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }
    }
}
