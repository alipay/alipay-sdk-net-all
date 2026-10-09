using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasFundConfirmResponse.
    /// </summary>
    public class AlipayTradeSaasFundConfirmResponse : AopResponse
    {
        /// <summary>
        /// Fundds已受理的超额部分自动退款金额，单位为元；等额认款时为0.00。
        /// </summary>
        [XmlElement("auto_refund_amount")]
        public string AutoRefundAmount { get; set; }

        /// <summary>
        /// 真实入金金额，单位为元，不等同于订单金额。
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 本次实际认款金额，单位为元。
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 本次商户认款请求幂等号。
        /// </summary>
        [XmlElement("claim_request_no")]
        public string ClaimRequestNo { get; set; }

        /// <summary>
        /// 已绑定的SaaS资金流水号。
        /// </summary>
        [XmlElement("fund_no")]
        public string FundNo { get; set; }

        /// <summary>
        /// SaaS交易主单号。无订单认款时由SaaS根据资金流水补建。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。无订单认款时由SaaS以资金流水号生成并固化。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 银行转账渠道交易号。Fundds返回ACCEPTED时即返回已创建设备的交易号，最终状态以订单查询或交易成功通知为准。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单当前状态。WAIT_BUYER_PAY：认款已受理，订单仍待支付结果；TRADE_SUCCESS：认款最终成功。Fundds返回ACCEPTED时为WAIT_BUYER_PAY，商户应通过订单查询或交易成功通知确认最终结果。
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
