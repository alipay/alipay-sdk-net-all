using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableScopeModify Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableScopeModify : AopObject
    {
        /// <summary>
        /// 可用门店修改信息
        /// </summary>
        [XmlElement("order_voucher_available_shop")]
        public OrderVoucherAvailableShopModify OrderVoucherAvailableShop { get; set; }
    }
}
