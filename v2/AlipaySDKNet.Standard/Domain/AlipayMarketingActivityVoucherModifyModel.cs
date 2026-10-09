using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherModifyModel : AopObject
    {
        /// <summary>
        /// 活动基础信息
        /// </summary>
        [XmlElement("activity_base_info")]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券可用范围
        /// </summary>
        [XmlElement("voucher_available_scope_info")]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// 券发放
        /// </summary>
        [XmlElement("voucher_send_mode_info")]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public PaymentVoucherUseRuleModify VoucherUseRule { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule_info")]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }
    }
}
