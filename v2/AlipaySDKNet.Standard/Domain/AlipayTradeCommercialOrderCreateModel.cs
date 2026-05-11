using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCommercialOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCommercialOrderCreateModel : AopObject
    {
        /// <summary>
        /// 本次支付关联的客户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 商品列表页code，在后台配置获取
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 本次支付关联的价格实例ID
        /// </summary>
        [XmlElement("price_id")]
        public string PriceId { get; set; }

        /// <summary>
        /// 订单支付成功后回跳地址
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
