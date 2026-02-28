using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrAddress Data Structure.
    /// </summary>
    [Serializable]
    public class IndrAddress : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 地区二位编码
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 所在州
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zipcode")]
        public string Zipcode { get; set; }
    }
}
