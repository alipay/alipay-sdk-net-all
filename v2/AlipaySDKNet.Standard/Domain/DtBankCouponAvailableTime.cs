using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankCouponAvailableTime Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankCouponAvailableTime : AopObject
    {
        /// <summary>
        /// 红包有效期开始时间(绝对时间)，time_type取值为ABSOLUTELY时，此参数有值。
        /// </summary>
        [XmlElement("absolutely_begin_time")]
        public string AbsolutelyBeginTime { get; set; }

        /// <summary>
        /// 红包有效期结束时间(绝对时间)，time_type取值为ABSOLUTELY时，此参数有值。
        /// </summary>
        [XmlElement("absolutely_end_time")]
        public string AbsolutelyEndTime { get; set; }

        /// <summary>
        /// 红包有效期时长，单位天，time_type取值为RELATIVE时，此参数有值。
        /// </summary>
        [XmlElement("relative_available_time")]
        public long RelativeAvailableTime { get; set; }

        /// <summary>
        /// 红包有效期开始时间类型，time_type取值为RELATIVE时，此参数有值。
        /// </summary>
        [XmlElement("relative_begin_time_type")]
        public string RelativeBeginTimeType { get; set; }

        /// <summary>
        /// 红包有效时间类型
        /// </summary>
        [XmlElement("time_type")]
        public string TimeType { get; set; }
    }
}
