using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAbsolutePeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAbsolutePeriodInfo : AopObject
    {
        /// <summary>
        /// 券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss  限制：  券可使用的结束时间valid_end_time 必须大于 券的发放结束时间 publish_end_time
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }
    }
}
