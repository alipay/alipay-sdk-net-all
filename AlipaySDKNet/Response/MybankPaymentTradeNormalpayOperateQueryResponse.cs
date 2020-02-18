using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOperateQueryResponse.
    /// </summary>
    public class MybankPaymentTradeNormalpayOperateQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易金额，请求支付或打款等操作时，传入的金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 外部平台的单据号，网商订单与外部平台订单一一对应
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码，按场景约定具体字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 网商受理支付或打款等操作时返回的流水号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 操作状态，ACCEPT：已受理，PROCESSING：处理中，SUCCESS：处理成功，FAIL：处理失败
        /// </summary>
        [XmlElement("operate_state")]
        public string OperateState { get; set; }

        /// <summary>
        /// 操作类型，PAYMENT：支付，REMITANCE：打款
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 网商创建的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 真实交易金额，操作达到终态时，该字段有值
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 请求受理时间，格式是yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_accept_time")]
        public string RequestAcceptTime { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 操作达到终态的时间，格式是yyyyMMddHHmmss
        /// </summary>
        [XmlElement("trans_time")]
        public string TransTime { get; set; }
    }
}
