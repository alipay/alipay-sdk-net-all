using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddressOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AddressOpenApiDTO : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家/区域
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 省/州
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
