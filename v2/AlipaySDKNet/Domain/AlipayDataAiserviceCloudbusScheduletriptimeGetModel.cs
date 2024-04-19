using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletriptimeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusScheduletriptimeGetModel : AopObject
    {
        /// <summary>
        /// mean/max/pert_95
        /// </summary>
        [XmlElement("aggregate_type")]
        public string AggregateType { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 配制id
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 5/10/15/20/30/60   Long 时间粒度(单位分钟)
        /// </summary>
        [XmlElement("time_span")]
        public long TimeSpan { get; set; }
    }
}
