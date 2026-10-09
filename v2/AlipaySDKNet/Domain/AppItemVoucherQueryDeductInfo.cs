using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherQueryDeductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherQueryDeductInfo : AopObject
    {
        /// <summary>
        /// 满减券优惠
        /// </summary>
        [XmlElement("app_item_fix_voucher_info")]
        public AppItemFixQueryVoucherInfo AppItemFixVoucherInfo { get; set; }

        /// <summary>
        /// 优惠类型
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }
    }
}
