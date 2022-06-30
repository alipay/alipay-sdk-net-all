using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherMerchantAllShopResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherMerchantAllShopResult : AopObject
    {
        /// <summary>
        /// 请求失败的不可用门店详情。
        /// </summary>
        [XmlArray("exclude_shop_fail_infos")]
        [XmlArrayItem("order_voucher_shop_fail_info")]
        public List<OrderVoucherShopFailInfo> ExcludeShopFailInfos { get; set; }

        /// <summary>
        /// 请求成功的不可用门店列表。
        /// </summary>
        [XmlArray("success_exclude_shop_ids")]
        [XmlArrayItem("string")]
        public List<string> SuccessExcludeShopIds { get; set; }
    }
}
