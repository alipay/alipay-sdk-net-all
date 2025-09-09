using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddCustomerCartModifyResponse.
    /// </summary>
    public class AlipayOfflineSmddCustomerCartModifyResponse : AopResponse
    {
        /// <summary>
        /// 优惠文案信息
        /// </summary>
        [XmlElement("discount_text")]
        public string DiscountText { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discounted_price")]
        public string DiscountedPrice { get; set; }

        /// <summary>
        /// 友好地异常信息（可以直接透出）
        /// </summary>
        [XmlElement("exception_msg")]
        public string ExceptionMsg { get; set; }

        /// <summary>
        /// 购物车原价
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 支付价
        /// </summary>
        [XmlElement("payment_price")]
        public string PaymentPrice { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_bean")]
        public List<SkuBean> SkuList { get; set; }

        /// <summary>
        /// 商品总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
