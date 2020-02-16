using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCloseResponse.
    /// </summary>
    public class AlipayTradeRepaybillOrderCloseResponse : AopResponse
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

        /// <summary>
        /// 订单还款状态 ("INIT", "初始"),("PROCESSING", "处理中")("SUCCESS", "成功"),("CLOSE", "关闭");
        /// </summary>
        [XmlElement("repay_order_status")]
        public string RepayOrderStatus { get; set; }
    }
}
