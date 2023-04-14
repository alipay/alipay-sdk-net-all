using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderVoucherAvailableScopeResult Data Structure.
    /// </summary>
    [Serializable]
    public class OrderVoucherAvailableScopeResult : AopObject
    {
        /// <summary>
        /// 可用门店请求结果。
        /// </summary>
        [XmlElement("order_voucher_available_shop_result")]
        public OrderVoucherAvailableShopResult OrderVoucherAvailableShopResult { get; set; }

        /// <summary>
        /// 可用范围类型。
        /// </summary>
        [XmlElement("voucher_available_type")]
        public string VoucherAvailableType { get; set; }
    }
}
