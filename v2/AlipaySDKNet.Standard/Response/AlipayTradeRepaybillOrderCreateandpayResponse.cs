using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCreateandpayResponse.
    /// </summary>
    public class AlipayTradeRepaybillOrderCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 还款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 还款的资金单号，后续用该单号去调用支付宝收银台sdk进行支付
        /// </summary>
        [XmlElement("repay_fund_order_no")]
        public string RepayFundOrderNo { get; set; }

        /// <summary>
        /// 订单还款状态，INIT：初始状态；PARTIAL_SUCCESS：部分还款成功；SUCCESS：全部还款成功；CLOSE：订单已经关闭
        /// </summary>
        [XmlElement("repay_status")]
        public string RepayStatus { get; set; }
    }
}
