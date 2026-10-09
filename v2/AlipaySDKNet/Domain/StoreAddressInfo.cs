using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StoreAddressInfo : AopObject
    {
        /// <summary>
        /// 门店地址（格式：市/区/详细地址门牌号）
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 高德门店维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 高德门店经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
