using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingCampaignqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingCampaignqueryModel : AopObject
    {
        /// <summary>
        /// 城市码和国家码都可以
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 环境信息
        /// </summary>
        [XmlElement("env_info")]
        public VoyagerEnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 扩展信息（Map 的 JSON string）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        [XmlElement("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 投放流量位ID
        /// </summary>
        [XmlElement("polymer_block_code")]
        public string PolymerBlockCode { get; set; }

        /// <summary>
        /// 用户userid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
