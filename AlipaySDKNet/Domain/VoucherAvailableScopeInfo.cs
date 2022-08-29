using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableScopeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableScopeInfo : AopObject
    {
        /// <summary>
        /// 券可用账号。
        /// </summary>
        [XmlElement("voucher_available_account_info")]
        public VoucherAvailableAccountInfo VoucherAvailableAccountInfo { get; set; }

        /// <summary>
        /// 券可用小程序。
        /// </summary>
        [XmlElement("voucher_available_app_info")]
        public VoucherAvailableAppInfo VoucherAvailableAppInfo { get; set; }

        /// <summary>
        /// 券可用地理位置。
        /// </summary>
        [XmlElement("voucher_available_geography_scope_info")]
        public VoucherAvailableGeographyScopeInfo VoucherAvailableGeographyScopeInfo { get; set; }

        /// <summary>
        /// 券可用商品。
        /// </summary>
        [XmlElement("voucher_available_goods_info")]
        public VoucherAvailableGoodsInfo VoucherAvailableGoodsInfo { get; set; }
    }
}
