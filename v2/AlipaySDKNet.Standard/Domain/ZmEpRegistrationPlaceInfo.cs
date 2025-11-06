using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmEpRegistrationPlaceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpRegistrationPlaceInfo : AopObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 中国行政区划代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行政区
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
