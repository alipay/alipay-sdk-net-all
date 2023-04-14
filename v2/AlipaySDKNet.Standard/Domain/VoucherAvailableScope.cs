using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableScope Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableScope : AopObject
    {
        /// <summary>
        /// 券可用城市信息。 当voucher_available_type=CITY_CODE时，该字段必填。
        /// </summary>
        [XmlElement("order_voucher_available_city_code")]
        public OrderVoucherAvailableCityCode OrderVoucherAvailableCityCode { get; set; }

        /// <summary>
        /// 券可用门店信息。当voucher_available_type=SHOP时，该字段必填。
        /// </summary>
        [XmlElement("order_voucher_available_shop")]
        public OrderVoucherAvailableShop OrderVoucherAvailableShop { get; set; }

        /// <summary>
        /// 可用范围类型。
        /// </summary>
        [XmlElement("voucher_available_type")]
        public string VoucherAvailableType { get; set; }
    }
}
