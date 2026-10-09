using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusTransitorridorQueryModel : AopObject
    {
        /// <summary>
        /// 接口版本控制
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结束时间， 可空，空代表到最近一个月
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 起始月份，<空>代表最早一个月
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 枚举值。空（默认）：所有  0: 公共出行   1: 不包含地铁  2: 现有线网
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
