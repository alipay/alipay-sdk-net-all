using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsVenueCreateModel : AopObject
    {
        /// <summary>
        /// 具体地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区域code
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 场馆是否可预定Y/N，不传默认可预定
        /// </summary>
        [XmlElement("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 场馆描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 场馆更多服务链接：可从文体场馆页跳转进此链接，进入服务商的该场馆页面
        /// </summary>
        [XmlElement("extra_service_url")]
        public string ExtraServiceUrl { get; set; }

        /// <summary>
        /// 接入方式： 空值/不传值/center  = 中心化 (场馆走文体中心统一规范）； half_center = 半中心化 （场馆走服务商的跳转链接）
        /// </summary>
        [XmlElement("join_type")]
        public string JoinType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 场馆名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 营业时间 开始时间 - 结束时间； (注：全英文符号）
        /// </summary>
        [XmlElement("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 主场馆在服务商的ID
        /// </summary>
        [XmlElement("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 联系电话，多个逗号隔开
        /// </summary>
        [XmlArray("phone")]
        [XmlArrayItem("string")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 场馆图片编码列表 最多5张，逗号隔开 图片要求参考场馆主图
        /// </summary>
        [XmlArray("picture_list")]
        [XmlArrayItem("string")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// POI
        /// </summary>
        [XmlElement("poi")]
        public string Poi { get; set; }

        /// <summary>
        /// 场馆主图海报图片的Base64编码 （注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接填写原文件的base64编码）
        /// </summary>
        [XmlElement("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合 calendar：价格日历 ticket：票券 course: 课程。 （注：中心化场馆必填，半中心化场馆不用填）
        /// </summary>
        [XmlArray("product_type_list")]
        [XmlArrayItem("string")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 省份code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 子场馆列表
        /// </summary>
        [XmlArray("sub_venue_list")]
        [XmlArrayItem("sub_venue_create_info")]
        public List<SubVenueCreateInfo> SubVenueList { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 是否为“测试场馆”。如果上传的场馆为想要进行测试的非正式场馆，则填写“Y”。如上传正式场馆，则不传或填写为N
        /// </summary>
        [XmlElement("test_venue")]
        public string TestVenue { get; set; }

        /// <summary>
        /// 交通信息
        /// </summary>
        [XmlElement("traffic")]
        public string Traffic { get; set; }

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
