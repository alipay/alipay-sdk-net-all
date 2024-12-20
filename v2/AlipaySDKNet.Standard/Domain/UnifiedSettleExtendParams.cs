using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnifiedSettleExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class UnifiedSettleExtendParams : AopObject
    {
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 直付通二级商户id，直付通收单模式必传
        /// </summary>
        [XmlElement("second_merchant_no")]
        public string SecondMerchantNo { get; set; }

        /// <summary>
        /// 直付通收单模式必传，目前仅支持alipay
        /// </summary>
        [XmlElement("second_merchant_type")]
        public string SecondMerchantType { get; set; }
    }
}
