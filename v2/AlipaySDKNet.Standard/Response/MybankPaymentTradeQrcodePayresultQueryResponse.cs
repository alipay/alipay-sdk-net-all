using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeQrcodePayresultQueryResponse.
    /// </summary>
    public class MybankPaymentTradeQrcodePayresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 受理时间
        /// </summary>
        [XmlElement("accept_time")]
        public string AcceptTime { get; set; }

        /// <summary>
        /// 关联业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        [XmlElement("operate_state")]
        public string OperateState { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 付款方户名
        /// </summary>
        [XmlElement("payer_card_name")]
        public string PayerCardName { get; set; }

        /// <summary>
        /// 付方卡号信息
        /// </summary>
        [XmlElement("payer_card_no")]
        public string PayerCardNo { get; set; }

        /// <summary>
        /// 实际交易金额单位分
        /// </summary>
        [XmlElement("real_trade_amt")]
        public string RealTradeAmt { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 交易金额单位分
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }
    }
}
