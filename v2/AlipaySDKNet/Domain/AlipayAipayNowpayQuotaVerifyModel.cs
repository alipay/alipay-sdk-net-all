using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpayQuotaVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpayQuotaVerifyModel : AopObject
    {
        /// <summary>
        /// COUNT 默认 1；POINT 为正整数，，单位次数或积分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 本次业务消耗额度的原因，仅用于留痕和审计；普通文本，最长 256 字符
        /// </summary>
        [XmlElement("consume_reason")]
        public string ConsumeReason { get; set; }

        /// <summary>
        /// 权益受益人
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 商品所有者
        /// </summary>
        [XmlElement("external_owner_id")]
        public string ExternalOwnerId { get; set; }

        /// <summary>
        /// 商品/应用标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 核销幂等号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
