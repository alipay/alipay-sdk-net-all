using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherAvailableShopResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherAvailableShopResult : AopObject
    {
        /// <summary>
        /// 商户全部门店可用请求结果。
        /// </summary>
        [XmlElement("order_voucher_merchant_all_shop_result")]
        public OrderVoucherMerchantAllShopResult OrderVoucherMerchantAllShopResult { get; set; }

        /// <summary>
        /// 请求失败的代运营商业关系门店详情
        /// </summary>
        [XmlArray("real_shop_fail_infos")]
        [XmlArrayItem("order_voucher_real_shop_fail_info")]
        public List<OrderVoucherRealShopFailInfo> RealShopFailInfos { get; set; }

        /// <summary>
        /// 请求失败的支付宝门店详情。
        /// </summary>
        [XmlArray("shop_fail_infos")]
        [XmlArrayItem("order_voucher_shop_fail_info")]
        public List<OrderVoucherShopFailInfo> ShopFailInfos { get; set; }

        /// <summary>
        /// 请求成功的代运营商业关系门店
        /// </summary>
        [XmlArray("success_real_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessRealShopIds { get; set; }

        /// <summary>
        /// 请求成功的支付宝门店。
        /// </summary>
        [XmlArray("success_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessShopIds { get; set; }
    }
}
