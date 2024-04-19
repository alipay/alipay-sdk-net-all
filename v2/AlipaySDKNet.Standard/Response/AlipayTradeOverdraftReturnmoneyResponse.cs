using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOverdraftReturnmoneyResponse.
    /// </summary>
    public class AlipayTradeOverdraftReturnmoneyResponse : AopResponse
    {
        /// <summary>
        /// 汇率（仅跨境追款执行成功后返回）
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 追款请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 追款收款账户
        /// </summary>
        [XmlElement("receive_account")]
        public string ReceiveAccount { get; set; }

        /// <summary>
        /// 退款时上传的外部请求号
        /// </summary>
        [XmlElement("refund_out_request_no")]
        public string RefundOutRequestNo { get; set; }

        /// <summary>
        /// 追款人民币金额（仅追款执行成功后返回）
        /// </summary>
        [XmlElement("return_amount")]
        public string ReturnAmount { get; set; }

        /// <summary>
        /// 追款外币金额（仅跨境追款执行成功后返回）
        /// </summary>
        [XmlElement("return_foreign_amount")]
        public string ReturnForeignAmount { get; set; }

        /// <summary>
        /// 追款外币币种（仅跨境追款执行成功后返回）
        /// </summary>
        [XmlElement("return_foreign_currency")]
        public string ReturnForeignCurrency { get; set; }

        /// <summary>
        /// 垫资追款结果。枚举值： SUCCESS：追款成功 FAILED：追款失败 PROCESSING：追款中
        /// </summary>
        [XmlElement("return_result")]
        public string ReturnResult { get; set; }

        /// <summary>
        /// 垫付追款完成时间
        /// </summary>
        [XmlElement("success_time")]
        public string SuccessTime { get; set; }
    }
}
