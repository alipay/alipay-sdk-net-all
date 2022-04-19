using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeRecContext Data Structure.
    /// </summary>
    [Serializable]
    public class ApeRecContext : AopObject
    {
        /// <summary>
        /// 用户当前城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 客户端环境
        /// </summary>
        [XmlElement("client_env")]
        public string ClientEnv { get; set; }

        /// <summary>
        /// 商品详情页当前商品的id，用于商品详情页的相关推荐（猜你喜欢）场景。
        /// </summary>
        [XmlElement("current_item_id")]
        public string CurrentItemId { get; set; }

        /// <summary>
        /// 用户设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 用户当前位置纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前位置经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
