using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherAvailableShopModify Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherAvailableShopModify : AopObject
    {
        /// <summary>
        /// 商户全部门店可用。
        /// </summary>
        [XmlElement("order_voucher_merchant_all_shop")]
        public OrderVoucherMerchantAllShopModify OrderVoucherMerchantAllShop { get; set; }

        /// <summary>
        /// 券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。
        /// </summary>
        [XmlArray("real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。接口参数是列表类型。
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
