using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChangedContent Data Structure.
    /// </summary>
    [Serializable]
    public class ChangedContent : AopObject
    {
        /// <summary>
        /// 失效时间延期特权-延期后预计失效时间
        /// </summary>
        [XmlElement("expire_deferral_after_expire_time")]
        public string ExpireDeferralAfterExpireTime { get; set; }

        /// <summary>
        /// 失效时间延期特权-总延期时间
        /// </summary>
        [XmlElement("expire_deferral_sum_deferral_time")]
        public string ExpireDeferralSumDeferralTime { get; set; }

        /// <summary>
        /// 失效时间延期特权-总延期时间单位
        /// </summary>
        [XmlElement("expire_deferral_sum_deferral_time_unit")]
        public string ExpireDeferralSumDeferralTimeUnit { get; set; }

        /// <summary>
        /// 失效时间延期特权-延期使用时间
        /// </summary>
        [XmlElement("expire_deferral_use_time")]
        public string ExpireDeferralUseTime { get; set; }
    }
}
