using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAipayNowpaydirectPurchaseConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAipayNowpaydirectPurchaseConsultModel : AopObject
    {
        /// <summary>
        /// 购买完成返回地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 外部会员id，业务侧的用户标识
        /// </summary>
        [XmlElement("external_buyer_id")]
        public string ExternalBuyerId { get; set; }

        /// <summary>
        /// 外部商品id，小程序商品详情页获取
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }
    }
}
