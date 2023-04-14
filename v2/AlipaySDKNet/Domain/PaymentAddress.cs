using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentAddress Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentAddress : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家编码，iso3166字母编码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 省/州
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
