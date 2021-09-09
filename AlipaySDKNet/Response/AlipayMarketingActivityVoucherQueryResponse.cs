using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称。 不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态 枚举值： INIT 未激活  ACTIVE：已激活 FINISHED：已停止  如果该值为空，说明活动还未创建成功。
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 归属商户信息
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public PaymentVoucherBelongMerchantInfo BelongMerchantInfo { get; set; }

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
        /// 券汇总信息
        /// </summary>
        [XmlElement("summary")]
        public VoucherSummary Summary { get; set; }

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
        /// 优惠类型  枚举值：  FIX_VOUCHER：固定面额满减券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 支付券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public PaymentVoucherUseRuleDetail VoucherUseRule { get; set; }
    }
}
