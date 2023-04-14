using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeQueryResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金流水号，用于商户与支付宝进行对账,资金处理成功时才有值
        /// </summary>
        [XmlElement("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 交易外部订单号,资金处理成功时才有值,供商户对账使用
        /// </summary>
        [XmlElement("alipay_out_trade_no")]
        public string AlipayOutTradeNo { get; set; }

        /// <summary>
        /// 金额,单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金状态,支付成功:PAY_SUCCESS, 支付失败:PAY_FAILED, 支付中:PAY_INPROGRESS
        /// </summary>
        [XmlElement("fund_status")]
        public string FundStatus { get; set; }

        /// <summary>
        /// 金额类型,扣款: pay 退款: refund
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 传入的扣款或退款资金单号
        /// </summary>
        [XmlElement("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 资金处理时间,格式"yyyy-MM-dd HH:mm:ss",无支付行为时为空
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
