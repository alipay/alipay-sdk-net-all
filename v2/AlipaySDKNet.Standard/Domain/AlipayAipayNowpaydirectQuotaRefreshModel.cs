using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectQuotaRefreshModel : AopObject
    {
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
        /// 核销时传入的幂等请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
