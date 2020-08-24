using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionAddress Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionAddress : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City or District or Suburb or Town or Village
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// State or County or Province
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
