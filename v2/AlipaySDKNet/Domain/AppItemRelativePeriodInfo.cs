using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemRelativePeriodInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemRelativePeriodInfo : AopObject
    {
        /// <summary>
        /// 券生效后N天内可以使用。 可以配合wait_days_after_receive字段使用。 比如：wait_days_after_receive=1，valid_days_after_receive=2，今天时1号0点0分0秒，那么2号0点0分0秒券生效可以开始使用，4号23点59分59秒，有效期到期不可用 单位：天
        /// </summary>
        [XmlElement("valid_days_after_receive")]
        public long ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 用户领券后需要等待N天，券才可以生效。 单位：天
        /// </summary>
        [XmlElement("wait_days_after_receive")]
        public long WaitDaysAfterReceive { get; set; }
    }
}
