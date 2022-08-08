using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeRecContext Data Structure.
    /// </summary>
    [Serializable]
    public class ApeRecContext : AopObject
    {
        /// <summary>
        /// 类目列表，推荐结果只会包含该类目的商品，为空时代表返回所有的商品。多个条件是与的关系。
        /// </summary>
        [XmlArray("cate")]
        [XmlArrayItem("string")]
        public List<string> Cate { get; set; }

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
        /// 承接的itemId列表
        /// </summary>
        [XmlArray("landing_item_list")]
        [XmlArrayItem("string")]
        public List<string> LandingItemList { get; set; }

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

        /// <summary>
        /// 指定召回的索引列表，例如：["crowdType#新客", "crowdType#老客"]，多个条件是与的关系。
        /// </summary>
        [XmlArray("other_index_list")]
        [XmlArrayItem("string")]
        public List<string> OtherIndexList { get; set; }

        /// <summary>
        /// 标签列表，推荐结果只会包含该标签的商品，为空时代表返回所有的商品。多个条件是与的关系。
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }
    }
}
