using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherDeductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherDeductInfo : AopObject
    {
        /// <summary>
        /// 满减券 当promoType=FIX_AMOUNT时不能为空
        /// </summary>
        [XmlElement("app_item_fix_voucher_info")]
        public AppItemFixVoucherInfo AppItemFixVoucherInfo { get; set; }

        /// <summary>
        /// 【描述】券类型 【枚举值】 ● 满减：FIX_AMOUNT
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }
    }
}
