using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectQuotaVerifyModel : AopObject
    {
        /// <summary>
        /// 核销数量
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 核销说明
        /// </summary>
        [XmlElement("consume_reason")]
        public string ConsumeReason { get; set; }

        /// <summary>
        /// 外部会员id
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 核销幂等请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
