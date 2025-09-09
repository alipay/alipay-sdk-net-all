using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartycommunityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityThirdpartycommunityCreateModel : AopObject
    {
        /// <summary>
        /// 小区地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 小区地址备注
        /// </summary>
        [XmlElement("address_memo")]
        public string AddressMemo { get; set; }

        /// <summary>
        /// 小区别名,后续检索时候可以使用上
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 市级行政编码
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区行政编码
        /// </summary>
        [XmlElement("community_adcode")]
        public string CommunityAdcode { get; set; }

        /// <summary>
        /// 社区中文名
        /// </summary>
        [XmlElement("community_adcode_name")]
        public string CommunityAdcodeName { get; set; }

        /// <summary>
        /// 同步的物业公司信息
        /// </summary>
        [XmlElement("community_property_company")]
        public CommunityPropertyCompany CommunityPropertyCompany { get; set; }

        /// <summary>
        /// 社区服务信息
        /// </summary>
        [XmlArray("community_service")]
        [XmlArrayItem("community_service")]
        public List<CommunityService> CommunityService { get; set; }

        /// <summary>
        /// 区县行政编码
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 小区所在城市的城市名。
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 小区热线电话
        /// </summary>
        [XmlElement("hot_line")]
        public string HotLine { get; set; }

        /// <summary>
        /// 服务热线每日服务结束时间。精度分钟
        /// </summary>
        [XmlElement("hot_line_end")]
        public string HotLineEnd { get; set; }

        /// <summary>
        /// 服务热线每日服务开始时间。精度：分钟
        /// </summary>
        [XmlElement("hot_line_start")]
        public string HotLineStart { get; set; }

        /// <summary>
        /// 小区经纬度，单位为度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 小区经度，单位为度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用户访问物业缴费查看的小区名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务商对于当前传入小区记录在内部的唯一编号
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 省级行政编码
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道编码
        /// </summary>
        [XmlElement("street_adcode")]
        public string StreetAdcode { get; set; }

        /// <summary>
        /// 街道中文
        /// </summary>
        [XmlElement("street_adcode_name")]
        public string StreetAdcodeName { get; set; }

        /// <summary>
        /// 物业社区支持类型
        /// </summary>
        [XmlElement("support_type")]
        public string SupportType { get; set; }

        /// <summary>
        /// 户号验证方式。后续用户绑定小区户号时执行的校验方式
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
