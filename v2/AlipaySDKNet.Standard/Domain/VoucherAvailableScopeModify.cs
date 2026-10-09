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
        /// 可用范围修改类型。
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 可用城市修改信息。
        /// </summary>
        [XmlElement("order_voucher_available_city_code")]
        public OrderVoucherAvailableCityCodeModify OrderVoucherAvailableCityCode { get; set; }

        /// <summary>
        /// 可用门店修改信息。
        /// </summary>
        [XmlElement("order_voucher_available_shop")]
        public OrderVoucherAvailableShopModify OrderVoucherAvailableShop { get; set; }
    }
}
