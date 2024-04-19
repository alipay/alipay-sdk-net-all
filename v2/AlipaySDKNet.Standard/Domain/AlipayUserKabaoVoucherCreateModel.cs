using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserKabaoVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserKabaoVoucherCreateModel : AopObject
    {
        /// <summary>
        /// 1、每批优惠券用一个唯一的批次id。 2、异常情况下，可以根据批次id对所有的优惠券进行订正。 3、不可为空。确保不同批次的优惠券的批次号不同，否则异常情况下将无法合理的进行数据订正。
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 业务使用场景
        /// </summary>
        [XmlElement("biz_use_scene")]
        public string BizUseScene { get; set; }

        /// <summary>
        /// 代金券的价值模型
        /// </summary>
        [XmlElement("cash_voucher_value_info")]
        public CashVoucherValueInfo CashVoucherValueInfo { get; set; }

        /// <summary>
        /// 优惠券有效期结束的时间点
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 兑换券的价值模型
        /// </summary>
        [XmlElement("exchange_voucher_value_info")]
        public ExchangeVoucherValueInfo ExchangeVoucherValueInfo { get; set; }

        /// <summary>
        /// 给支付宝用户发券的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户侧优惠券的唯一标识
        /// </summary>
        [XmlElement("out_instance_id")]
        public string OutInstanceId { get; set; }

        /// <summary>
        /// 优惠券归属的信息，比如归属的小程序id，品牌名称等。
        /// </summary>
        [XmlElement("principal_info")]
        public VoucherPrincipalInfo PrincipalInfo { get; set; }

        /// <summary>
        /// 优惠券规则信息
        /// </summary>
        [XmlElement("rule_info")]
        public VoucherRuleInfo RuleInfo { get; set; }

        /// <summary>
        /// 优惠券有效期的开始时间点
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 优惠券类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 优惠券使用信息
        /// </summary>
        [XmlElement("usage_info")]
        public VoucherUsageInfo UsageInfo { get; set; }

        /// <summary>
        /// 给支付宝用户发券的2088uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
