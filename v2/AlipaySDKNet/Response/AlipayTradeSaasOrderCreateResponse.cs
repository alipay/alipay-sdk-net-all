using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasOrderCreateResponse.
    /// </summary>
    public class AlipayTradeSaasOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 聚合收银台短链访问地址。商户将用户跳转到该地址后，浏览器会重定向到带收银台访问凭证的完整地址。
        /// </summary>
        [XmlElement("cashier_url")]
        public string CashierUrl { get; set; }

        /// <summary>
        /// SaaS交易订单号。仅在显式单选银行转账且同步创单成功时返回。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。仅在显式单选银行转账且同步创单成功时返回。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次银行转账实际使用的SaaS账户信息。仅在显式单选银行转账且同步创单成功时返回。
        /// </summary>
        [XmlElement("saas_account_info")]
        public SaasAccountInfo SaasAccountInfo { get; set; }

        /// <summary>
        /// 银行渠道交易号。仅在显式单选银行转账且同步创单成功时返回。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 银行转账交易状态。同步创单成功后返回 WAIT_BUYER_PAY；重复创建命中终态时可能返回 TRADE_SUCCESS 或 TRADE_CLOSED。
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
