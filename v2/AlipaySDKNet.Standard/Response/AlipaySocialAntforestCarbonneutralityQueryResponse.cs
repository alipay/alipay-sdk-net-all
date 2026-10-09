using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestCarbonneutralityQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestCarbonneutralityQueryResponse : AopResponse
    {
        /// <summary>
        /// 人人1kg预计碳中和排放量
        /// </summary>
        [XmlElement("carbon_neutrality_biz_count")]
        public long CarbonNeutralityBizCount { get; set; }

        /// <summary>
        /// 人人1kg参与人数
        /// </summary>
        [XmlElement("carbon_neutrality_people_count")]
        public long CarbonNeutralityPeopleCount { get; set; }

        /// <summary>
        /// 绿色生活方式的打卡人次
        /// </summary>
        [XmlElement("green_life_tick_times")]
        public long GreenLifeTickTimes { get; set; }
    }
}
