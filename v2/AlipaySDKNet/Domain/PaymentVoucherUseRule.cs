using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherUseRule : AopObject
    {
        /// <summary>
        /// 可核销的支付宝小程序id  限制：  1、必须是支付宝小程序 2、如果包含重复的小程序id会自动进行去重操作。
        /// </summary>
        [XmlArray("available_app_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableAppIds { get; set; }

        /// <summary>
        /// 可核销商品详情  限制: 1、available_goods与unavailable_goods_ids只能二选一或者同时为空
        /// </summary>
        [XmlElement("available_goods")]
        public PaymentVoucherAvailableGoods AvailableGoods { get; set; }

        /// <summary>
        /// 可核销商户
        /// </summary>
        [XmlElement("available_merchant")]
        public PaymentVoucherAvailableMerchant AvailableMerchant { get; set; }

        /// <summary>
        /// 可核销支付门店id。 限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。
        /// </summary>
        [XmlArray("available_store_ids")]
        [XmlArrayItem("string")]
        public List<string> AvailableStoreIds { get; set; }

        /// <summary>
        /// 固定面额满减券使用规则。 限制: 1、voucher_type为FIX_VOUCHER时必填
        /// </summary>
        [XmlElement("fix_voucher")]
        public PaymentFixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。  限制: 1、available_goods与unavailable_goods_ids只能二选一或者同时为空
        /// </summary>
        [XmlArray("unavailable_goods_ids")]
        [XmlArrayItem("string")]
        public List<string> UnavailableGoodsIds { get; set; }

        /// <summary>
        /// 核销跳转方式,默认CAN_USE(详情页展示可使用按钮) 枚举值: SCAN_CODE 跳转到支付宝收钱码 SELF_LINK 跳转至商家指定页面 CAN_USE 卡包券详情页显示可使用按钮
        /// </summary>
        [XmlElement("use_mode")]
        public string UseMode { get; set; }

        /// <summary>
        /// 核销跳转链接 限制: 1、只有use_mode为SELF_LINK时该值有效且必传。 2、核销跳转链接必须是支付宝小程序链接。
        /// </summary>
        [XmlElement("use_url")]
        public string UseUrl { get; set; }

        /// <summary>
        /// 每个支付宝账号的核销次数限制。 默认不限制
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user")]
        public long VoucherQuantityLimitPerUser { get; set; }

        /// <summary>
        /// 核销次数限制周期配置。默认值LIFE_CYCLE表示限制每个支付宝账号在整个活动期间核销次数。  枚举值: DAY:每天  WEEK:每周  MONTH:每月  LIFE_CYCLE:整个活动
        /// </summary>
        [XmlElement("voucher_quantity_limit_per_user_period_type")]
        public string VoucherQuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// 允许指定券的特殊生效时间规则。
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public PaymentVoucherValidPeriod VoucherValidPeriod { get; set; }
    }
}
