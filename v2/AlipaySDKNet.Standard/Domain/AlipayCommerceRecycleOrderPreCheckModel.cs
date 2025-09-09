using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderPreCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderPreCheckModel : AopObject
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单的卖家id。
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }
    }
}
