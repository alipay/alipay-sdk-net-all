using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherCreateModel : AopObject
    {
        /// <summary>
        /// 活动名称。 不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 归属商户信息，默认归属商户为当前请求商户
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public PaymentVoucherBelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss 限制： 券发放结束时间 publish_end_time 与 券发放开始时间 publish_start_time 间隔必须小于等于180天
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 营销资金预算
        /// </summary>
        [XmlElement("voucher_budget_info")]
        public PaymentVoucherBudgetInfo VoucherBudgetInfo { get; set; }

        /// <summary>
        /// 券详情页
        /// </summary>
        [XmlElement("voucher_display_info")]
        public PaymentVoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public PaymentVoucherSendRule VoucherSendRule { get; set; }

        /// <summary>
        /// 优惠类型  枚举值： FIX_VOUCHER：固定面额满减券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public PaymentVoucherUseRule VoucherUseRule { get; set; }
    }
}
