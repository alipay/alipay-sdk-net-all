using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCreateResponse.
    /// </summary>
    public class AlipayTradeRepaybillOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 还款的资金单号，后续用该单号去调用支付宝收银台sdk进行支付
        /// </summary>
        [XmlElement("repay_fund_order_no")]
        public string RepayFundOrderNo { get; set; }
    }
}
