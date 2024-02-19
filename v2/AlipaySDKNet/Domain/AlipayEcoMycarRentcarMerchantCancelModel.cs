using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarMerchantCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarMerchantCancelModel : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 扣款金额，单位分，没有违约金则传0
        /// </summary>
        [XmlElement("deduct_amount")]
        public long DeductAmount { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号，支付宝侧使用商户pid+商户订单号做订单唯一性校验及幂等控制
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
