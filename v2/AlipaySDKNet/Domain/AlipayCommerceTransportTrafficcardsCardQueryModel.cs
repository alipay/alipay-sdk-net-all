using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTrafficcardsCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTrafficcardsCardQueryModel : AopObject
    {
        /// <summary>
        /// 需要查询乘车码的城市编码，参考中华人民共和国行政区划编码，仅支持市级维度
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 需要查询乘车码的城市名称，支持模糊匹配，是否以市结尾均可
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 用户当前纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户当前提问文本
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 乘车卡场景，BUS代表只查询公交，METRO代表只查询地铁，空则默认查询所有场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 字符串类型，标识请求来源，固定大写例如千问：QWEN
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
