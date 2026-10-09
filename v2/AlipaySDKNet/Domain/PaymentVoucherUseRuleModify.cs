using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherUseRuleModify Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherUseRuleModify : AopObject
    {
        /// <summary>
        /// 可核销的支付宝小程序id   限制：  1、必须是支付宝小程序  2、如果包含重复的小程序id会自动进行去重操作。 3、可核销小程序范围只能扩大不能缩小
        /// </summary>
        [XmlElement("available_app_ids")]
        public string AvailableAppIds { get; set; }

        /// <summary>
        /// 可核销商品
        /// </summary>
        [XmlElement("available_goods")]
        public PaymentVoucherAvailableGoodsModify AvailableGoods { get; set; }

        /// <summary>
        /// 可核销商户
        /// </summary>
        [XmlElement("available_merchant")]
        public PaymentVoucherAvailableMerchantModify AvailableMerchant { get; set; }

        /// <summary>
        /// 可核销支付门店id。   限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。 3、可核销门店范围只能扩大不能缩小
        /// </summary>
        [XmlElement("available_store_ids")]
        public string AvailableStoreIds { get; set; }

        /// <summary>
        /// 允许指定券的特殊生效时间规则。
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public PaymentVoucherValidPeriodModify VoucherValidPeriod { get; set; }
    }
}
