using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankResult Data Structure.
    /// </summary>
    [Serializable]
    public class RankResult : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 车辆列表
        /// </summary>
        [XmlArray("car_list")]
        [XmlArrayItem("rank_car")]
        public List<RankCar> CarList { get; set; }

        /// <summary>
        /// 榜单数据值 销售榜为销售数据 降价榜为百分比值
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 降价数值
        /// </summary>
        [XmlElement("descender_price")]
        public string DescenderPrice { get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        [XmlElement("detail_info")]
        public DetailInfo DetailInfo { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 上次排名
        /// </summary>
        [XmlElement("last_rank")]
        public string LastRank { get; set; }

        /// <summary>
        /// 上次排名数据值
        /// </summary>
        [XmlElement("last_rank_value")]
        public string LastRankValue { get; set; }

        /// <summary>
        /// max_price
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 排名
        /// </summary>
        [XmlElement("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 排名数据类型
        /// </summary>
        [XmlElement("rank_data_type")]
        public string RankDataType { get; set; }

        /// <summary>
        /// 车系id
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 车系能源类型
        /// </summary>
        [XmlElement("series_new_energy_type")]
        public string SeriesNewEnergyType { get; set; }

        /// <summary>
        /// 排行数据说明
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
