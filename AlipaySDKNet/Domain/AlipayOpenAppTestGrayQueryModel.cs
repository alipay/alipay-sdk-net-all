using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestGrayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestGrayQueryModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("buy_open_id")]
        public string BuyOpenId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
