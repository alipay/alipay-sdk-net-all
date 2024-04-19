using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitValidPeriodDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitValidPeriodDTO : AopObject
    {
        /// <summary>
        /// 当type为 RELATIVE时，该字段必填 0代表立即生效 3600代表1小时后开始生效
        /// </summary>
        [XmlElement("active_seconds_after_receive")]
        public long ActiveSecondsAfterReceive { get; set; }

        /// <summary>
        /// 权益生效时间，ISO8601格式,当type为ABSOLUTE时必填 0时区: "2022-09-01T12:08:56Z"
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 当type为ABSOLUTE时必填 0时区: "2022-09-30T12:08:56Z"
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当type为RELATIVE时,该字段必填 领取权益后多少秒开始失效，该值一定要比 activeSeconds大
        /// </summary>
        [XmlElement("expire_seconds_after_receive")]
        public long ExpireSecondsAfterReceive { get; set; }

        /// <summary>
        /// ABSOLUTE ：绝对时间区间类型;RELATIVE ： 相对领取时间类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
