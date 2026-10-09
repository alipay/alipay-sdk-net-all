using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectPurchaseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectPurchaseCreateModel : AopObject
    {
        /// <summary>
        /// 购买完成返回地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 外部买家会员id
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 商品外部id，可从小程序商品详情页获取
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 购买外部请求号，用于幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 可选，希望直接指定购买档位时可传入
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
