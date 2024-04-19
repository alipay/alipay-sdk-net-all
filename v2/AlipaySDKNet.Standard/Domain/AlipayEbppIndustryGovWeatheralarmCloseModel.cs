using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovWeatheralarmCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovWeatheralarmCloseModel : AopObject
    {
        /// <summary>
        /// 天气预警唯一id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 各气象局来源平台，由支付宝政务分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
