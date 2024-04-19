using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransferAddressInfo : AopObject
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
        /// 地市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 两位国家编码
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 州/省份
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
