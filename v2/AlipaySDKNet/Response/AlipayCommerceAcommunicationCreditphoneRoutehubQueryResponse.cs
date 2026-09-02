using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRoutehubQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneRoutehubQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 运营商侧订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 退款查询明细
        /// </summary>
        [XmlElement("refund_query_result")]
        public RefundQueryResult RefundQueryResult { get; set; }

        /// <summary>
        /// 签约绑定查询明细
        /// </summary>
        [XmlElement("sign_query_result")]
        public SignQueryResult SignQueryResult { get; set; }

        /// <summary>
        /// 代扣查询明细
        /// </summary>
        [XmlElement("transfer_query_result")]
        public TransferQueryResult TransferQueryResult { get; set; }

        /// <summary>
        /// 解约查询明细
        /// </summary>
        [XmlElement("unbind_query_result")]
        public UnbindQueryResult UnbindQueryResult { get; set; }
    }
}
