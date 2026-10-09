using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryGovWeatheralarmSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryGovWeatheralarmSyncModel : AopObject
    {
        /// <summary>
        /// 天气预警详情信息
        /// </summary>
        [XmlArray("alarm_list")]
        [XmlArrayItem("alarm_info")]
        public List<AlarmInfo> AlarmList { get; set; }

        /// <summary>
        /// 来源平台编号，由支付宝政务分配
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
