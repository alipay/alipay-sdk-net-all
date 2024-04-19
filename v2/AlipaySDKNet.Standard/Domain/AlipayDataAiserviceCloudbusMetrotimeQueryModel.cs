using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetrotimeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusMetrotimeQueryModel : AopObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 6位目的地geohash
        /// </summary>
        [XmlElement("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// 结束年月
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 进出站 0：进站  1：出站
        /// </summary>
        [XmlElement("is_out")]
        public long IsOut { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 开始年月
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 地铁站名称
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 操作类型： 0：普通（默认）  1：潜在
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
