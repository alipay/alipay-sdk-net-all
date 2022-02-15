using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBusinessOperateQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBusinessOperateQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务场景(这个场景固定值)，下单中入参
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 请求完结时间，格式是yyyy-MM-dd HH:mm:ss 对于支付，就是支付时间 对于退款，就是退款时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 网商操作单号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 操作状态 SUCCESS 成功的 FAIL 失败的 PROCESSING 处理中 INIT 初始化
        /// </summary>
        [XmlElement("operate_status")]
        public string OperateStatus { get; set; }

        /// <summary>
        /// PAYMENT：支付 REFUND：退款 SETTLEMENT：结算分账
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 下单的外部平台的单据号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 签约的产品码(固定值)，下单中入参
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 操作的请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台是否需要原单重试，失败时有值
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 交易金额，单位元
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }
    }
}
