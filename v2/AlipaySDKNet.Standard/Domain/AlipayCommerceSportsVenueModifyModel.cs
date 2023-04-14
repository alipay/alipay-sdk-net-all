using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueModifyModel : AopObject
    {
        /// <summary>
        /// 变更具体位置
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 变更区域code
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 是否可预定 Y/N  （不传默认为可预定）
        /// </summary>
        [XmlElement("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 变更城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 变更场馆介绍
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 场馆更多服务链接：可从文体场馆页跳转进此链接，进入服务商的该场馆页面
        /// </summary>
        [XmlElement("extra_service_url")]
        public string ExtraServiceUrl { get; set; }

        /// <summary>
        /// 接入方式： center = 中心化 (场馆走文体中心统一规范）； half_center = 半中心化 （场馆走服务商的跳转链接）。 半中心化场馆如修改为中心化场馆，请注意数据补全
        /// </summary>
        [XmlElement("join_type")]
        public string JoinType { get; set; }

        /// <summary>
        /// 变更纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 变更经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 变更场馆名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 变更营业时间 开始时间 - 结束时间
        /// </summary>
        [XmlElement("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 主场馆在服务商的id，不可变更
        /// </summary>
        [XmlElement("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 变更联系电话
        /// </summary>
        [XmlArray("phone")]
        [XmlArrayItem("string")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 变更场馆图片Base64编码列表 最多5张图片。要求参见场馆主图
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("string")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// poi
        /// </summary>
        [XmlElement("poi")]
        public string Poi { get; set; }

        /// <summary>
        /// 变更场馆主图海报图片的Base64编码 （注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接填写原文件的base64编码）
        /// </summary>
        [XmlElement("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合，逗号隔开 calendar：价格日历 ticket：票券 course: 课程
        /// </summary>
        [XmlArray("product_type_list")]
        [XmlArrayItem("string")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 变更省份code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 变更状态，online/offline
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子场馆列表
        /// </summary>
        [XmlArray("sub_venue_list")]
        [XmlArrayItem("sub_venue_modify_info")]
        public List<SubVenueModifyInfo> SubVenueList { get; set; }

        /// <summary>
        /// 变更标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 变更交通信息
        /// </summary>
        [XmlElement("traffic")]
        public string Traffic { get; set; }

        /// <summary>
        /// 支付宝主场馆ID，不可变更
        /// </summary>
        [XmlElement("venue_id")]
        public string VenueId { get; set; }

        /// <summary>
        /// 场馆商户pid
        /// </summary>
        [XmlElement("venue_pid")]
        public string VenuePid { get; set; }

        /// <summary>
        /// 场馆类型， 01足球；02篮球；03乒乓球；04羽毛球；05台球；06射箭；07哒哒球；08游泳；09网球；10攀岩；11空手道；12跆拳道；14瑜伽；15搏击；16舞蹈；17艺术体操；18太极；19击剑；20水上运动；21滑雪；22健身；23轮滑；24排球；25门球；00其他运动
        /// </summary>
        [XmlArray("venue_type")]
        [XmlArrayItem("string")]
        public List<string> VenueType { get; set; }
    }
}
