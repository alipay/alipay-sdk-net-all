using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntsportsCurrentpathQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntsportsCurrentpathQueryModel : AopObject
    {
        /// <summary>
        /// 日期。格式yyyy-MM-dd
        /// </summary>
        [XmlElement("day")]
        public string Day { get; set; }

        /// <summary>
        /// 路线场景
        /// </summary>
        [XmlElement("path_scene")]
        public string PathScene { get; set; }

        /// <summary>
        /// 路线归属站点编码
        /// </summary>
        [XmlElement("path_station_code")]
        public string PathStationCode { get; set; }

        /// <summary>
        /// 路线归属站点名称
        /// </summary>
        [XmlElement("path_station_name")]
        public string PathStationName { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
