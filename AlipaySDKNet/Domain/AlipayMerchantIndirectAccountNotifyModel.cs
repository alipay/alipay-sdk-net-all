using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectAccountNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectAccountNotifyModel : AopObject
    {
        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 间联小程序ID
        /// </summary>
        [XmlElement("mrchind_app_id")]
        public string MrchindAppId { get; set; }

        /// <summary>
        /// 外部唯一流水编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部商户编号(银行商户号)
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }

        /// <summary>
        /// 支付渠道，参考枚举如下： ALIPAY:支付宝 WECHAT_PAY:微信支付 UNION_PAY:银联支付 OTHER 其他付款方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 商户smid (支付宝进件商户号)
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 当日收款总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 当日收款总笔数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
