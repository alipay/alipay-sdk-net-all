using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxRefundAddress Data Structure.
    /// </summary>
    [Serializable]
    public class TaxRefundAddress : AopObject
    {
        /// <summary>
        /// 地址1
        /// </summary>
        [XmlElement("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// 地址2
        /// </summary>
        [XmlElement("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 州或国家或省
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
