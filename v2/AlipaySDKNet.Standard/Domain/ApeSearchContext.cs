using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApeSearchContext Data Structure.
    /// </summary>
    [Serializable]
    public class ApeSearchContext : AopObject
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
        /// 用户设备id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 已经曝光的item列表，用于曝光去重，多个itemid用,分割，这部分item不会出现在推荐结果中。
        /// </summary>
        [XmlArray("expose_item_list")]
        [XmlArrayItem("string")]
        public List<string> ExposeItemList { get; set; }

        /// <summary>
        /// 搜索的过滤条件
        /// </summary>
        [XmlElement("filter_condition")]
        public string FilterCondition { get; set; }

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
        /// 召回个数 当前字段已废弃(接口有另外定义，不在需要此处定义)
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 排序类型，传的结构为字段+"#"+顺序，比如需要价格倒叙 current_price#desc,价格顺序 current_price#asc,销量倒叙 sale_number#desc
        /// </summary>
        [XmlElement("sort_type")]
        public string SortType { get; set; }

        /// <summary>
        /// 召回起始位置( 当前字段已废弃(接口有另外定义，不在需要此处定义)
        /// </summary>
        [XmlElement("start_index")]
        public long StartIndex { get; set; }
    }
}
