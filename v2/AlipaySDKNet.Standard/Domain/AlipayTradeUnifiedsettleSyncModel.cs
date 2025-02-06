using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeUnifiedsettleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeUnifiedsettleSyncModel : AopObject
    {
        /// <summary>
        /// 收单模式，目前仅支持PLATFORM_BUSINESS
        /// </summary>
        [XmlElement("acquire_mode")]
        public string AcquireMode { get; set; }

        /// <summary>
        /// 订单同步金额，biz_type=PAY_SYNC时为支付金额，biz_type=REFUND_SYNC时为退款金额。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public UnifiedSettleExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 实际外部支付渠道支付或退款发生时间
        /// </summary>
        [XmlElement("external_inst_biz_date")]
        public string ExternalInstBizDate { get; set; }

        /// <summary>
        /// 外部收单渠道
        /// </summary>
        [XmlElement("external_inst_channel")]
        public string ExternalInstChannel { get; set; }

        /// <summary>
        /// 实际外部支付渠道交易创建时间
        /// </summary>
        [XmlElement("external_inst_create_date")]
        public string ExternalInstCreateDate { get; set; }

        /// <summary>
        /// 退款流水号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端单笔交易维度不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 签约产品码，目前仅支持UNIFIED_SETTLE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 同步流水的类型，支付为PAY_SYNC，退款为REFUND_SYNC
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 结算信息， 直付通模式下requestType=PAY_SYNC时必传。
        /// </summary>
        [XmlElement("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 二级商户信息。 直付通模式下requestType=PAY_SYNC时必传
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }
    }
}
