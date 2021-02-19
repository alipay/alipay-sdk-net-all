using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityConsultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityConsultInfo : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 错误码：领取超限(RECEIVE_LIMIT_EXCEEDED)，券余量不足(VOUCHER_INSUFFICIENT_EXCEPTION)，通用领取异常(RECEIVE_FAIL_ERROR)
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否可领
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
