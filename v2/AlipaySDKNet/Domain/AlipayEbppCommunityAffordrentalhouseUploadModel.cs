using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityAffordrentalhouseUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityAffordrentalhouseUploadModel : AopObject
    {
        /// <summary>
        /// 详细地址信息
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 6位城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 房源详情链接,可以使用h5链接或者小程序链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 户型列表
        /// </summary>
        [XmlArray("house_mode_list")]
        [XmlArrayItem("house_mode")]
        public List<HouseMode> HouseModeList { get; set; }

        /// <summary>
        /// 户型数量，小区一共有多少种户型
        /// </summary>
        [XmlElement("house_mode_num")]
        public long HouseModeNum { get; set; }

        /// <summary>
        /// 当前保租房源可租房子数
        /// </summary>
        [XmlElement("house_num")]
        public long HouseNum { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 房源所属平台编码
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 房源所属平台唯一编码
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 房源所属名称
        /// </summary>
        [XmlElement("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// 房源状态 0 上线 1下线
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 房源标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
