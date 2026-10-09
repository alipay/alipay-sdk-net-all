using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectQuotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectQuotaQueryModel : AopObject
    {
        /// <summary>
        /// 外部会员id
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 外部商品id，可在小程序商品详情页获取
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }
    }
}
