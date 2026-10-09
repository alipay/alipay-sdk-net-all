using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasFundConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasFundConfirmModel : AopObject
    {
        /// <summary>
        /// 资金确认动作。CONFIRM表示认款，REJECT表示拒绝待认款资金并全额退款；不传默认CONFIRM。REJECT仅需传fund_no，不应传order_no、trade_no或claim_amount。
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 本次认款金额，单位为元，最多保留两位小数，范围为0.01至100000000.00。仅在order_no和trade_no均不传时生效；无订单且未传时按真实入金金额认款，传入时不能大于真实入金金额。
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 商户认款请求幂等号。仅允许字母、数字和下划线，重试时必须沿用原值；相同请求号对应的入金、订单和认款金额不能变化。
        /// </summary>
        [XmlElement("claim_request_no")]
        public string ClaimRequestNo { get; set; }

        /// <summary>
        /// SaaS资金流水号。必须是待认款的入金资金流水，商户应使用资金通知或资金查询返回的值。
        /// </summary>
        [XmlElement("fund_no")]
        public string FundNo { get; set; }

        /// <summary>
        /// SaaS交易主单号。可选；与trade_no同时传入时，两个标识必须对应同一订单，否则返回INVALID_PARAMETER。order_no和trade_no均不传时按资金流水补建订单。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 银行转账渠道交易号。可选；与order_no同时传入时，两个标识必须对应同一订单，否则返回INVALID_PARAMETER。order_no和trade_no均不传时按资金流水补建订单。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
