using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRelationshipCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityRelationshipCreateModel : AopObject
    {
        /// <summary>
        /// 小区短名, 创建小区时创建
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 日常服务开始时间，例如24:00
        /// </summary>
        [XmlElement("daily_end")]
        public string DailyEnd { get; set; }

        /// <summary>
        /// 日常服务开始时间，例如00:00
        /// </summary>
        [XmlElement("daily_start")]
        public string DailyStart { get; set; }

        /// <summary>
        /// 物业公司的短名,在创建物业公司时生成
        /// </summary>
        [XmlElement("property_short_name")]
        public string PropertyShortName { get; set; }

        /// <summary>
        /// 服务结束时间，格式：yyyy-MM-dd HH:mm:ss（精度只到日期）
        /// </summary>
        [XmlElement("service_end")]
        public string ServiceEnd { get; set; }

        /// <summary>
        /// 服务开始时间，格式为yyyy-MM-dd HH:mm:ss（精度只到日期）
        /// </summary>
        [XmlElement("service_start")]
        public string ServiceStart { get; set; }

        /// <summary>
        /// 服务类型，不传默认为物业缴费THIRD_PARTY_COMMUNITY_JIAOFEI
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
