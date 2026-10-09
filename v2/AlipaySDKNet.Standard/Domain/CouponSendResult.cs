using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponSendResult Data Structure.
    /// </summary>
    [Serializable]
    public class CouponSendResult : AopObject
    {
        /// <summary>
        /// 发放奖品的id，发放成功时必填
        /// </summary>
        [XmlElement("coupon_code")]
        public string CouponCode { get; set; }

        /// <summary>
        /// 发放失败错误码，发放失败必填
        /// </summary>
        [XmlElement("fail_reason_code")]
        public string FailReasonCode { get; set; }

        /// <summary>
        /// 发放失败原因描述，发放失败时必填
        /// </summary>
        [XmlElement("fail_reason_message")]
        public string FailReasonMessage { get; set; }

        /// <summary>
        /// 奖品是否发放成功
        /// </summary>
        [XmlElement("send_result")]
        public bool SendResult { get; set; }
    }
}
