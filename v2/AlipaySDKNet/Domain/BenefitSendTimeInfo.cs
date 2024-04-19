using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitSendTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitSendTimeInfo : AopObject
    {
        /// <summary>
        /// 代表限定周期时间类型 DAY_OF_WEEK:星期维度
        /// </summary>
        [XmlElement("cycle_period_type")]
        public string CyclePeriodType { get; set; }

        /// <summary>
        /// 代表发放周期类型(cycle_period_type)下具体值。 比如： cycle_period_type=DAY_OF_WEEK，cycle_period_value=["MON","TUE","WEB"], 代表：周一、周二、周三
        /// </summary>
        [XmlArray("cycle_period_value")]
        [XmlArrayItem("string")]
        public List<string> CyclePeriodValue { get; set; }

        /// <summary>
        /// 红包发放开始时间
        /// </summary>
        [XmlElement("send_begin_time")]
        public string SendBeginTime { get; set; }

        /// <summary>
        /// 红包发放结束时间
        /// </summary>
        [XmlElement("send_end_time")]
        public string SendEndTime { get; set; }

        /// <summary>
        /// 代表在周期时间范围下，子周期限定时间类型 SECOND_OF_DAY:一天内具体时间点(秒为单位)
        /// </summary>
        [XmlElement("sub_cycle_period_type")]
        public string SubCyclePeriodType { get; set; }

        /// <summary>
        /// 代表发放周期类型(cycle_period_type)下具体值。 比如： cycle_period_type=SECOND_OF_DAY，cycle_period_value=["01:53:28-02:53:28","05:10:10-08:30:30"], 代表： 子时间段为每天的01点53分28秒到02点53分28秒，05点10分10秒到08点30分30秒
        /// </summary>
        [XmlArray("sub_cycle_period_value")]
        [XmlArrayItem("string")]
        public List<string> SubCyclePeriodValue { get; set; }
    }
}
