using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// HuanxuTradeOrderCloseResponse.
    /// </summary>
    public class HuanxuTradeOrderCloseResponse : AopResponse
    {
        /// <summary>
        /// 聚合支付的支付渠道，焕旭分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于透传扩展信息，pay_url为支付链接。
        /// </summary>
        [XmlElement("ext_context")]
        public ExtContext ExtContext { get; set; }

        /// <summary>
        /// 支付金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付请求号，对应一笔业务订单下的一次支付请求，不同支付请求需保证请求号唯一
        /// </summary>
        [XmlElement("pay_request_no")]
        public string PayRequestNo { get; set; }

        /// <summary>
        /// 支付id，焕旭针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [XmlElement("payment_id")]
        public string PaymentId { get; set; }
    }
}
