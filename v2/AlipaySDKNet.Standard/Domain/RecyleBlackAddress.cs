using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyleBlackAddress Data Structure.
    /// </summary>
    [Serializable]
    public class RecyleBlackAddress : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
