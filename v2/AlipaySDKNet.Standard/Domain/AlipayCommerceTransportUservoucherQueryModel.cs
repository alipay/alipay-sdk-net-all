using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportUservoucherQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportUservoucherQueryModel : AopObject
    {
        /// <summary>
        /// 达到机场三字码
        /// </summary>
        [XmlElement("arr_city")]
        public string ArrCity { get; set; }

        /// <summary>
        /// 到达城市行政区划码
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        ///  出发机场三字码
        /// </summary>
        [XmlElement("dep_city")]
        public string DepCity { get; set; }

        /// <summary>
        /// 出发城市行政区划码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// JSON格式，用于后续扩展使用
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// DOMESTIC国内机票，INTERNATIONAL国际机票
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// ROUND_TRIP往返，ONE_WAY单程
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
