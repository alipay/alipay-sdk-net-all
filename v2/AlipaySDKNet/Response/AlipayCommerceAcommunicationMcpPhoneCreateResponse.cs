using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationMcpPhoneCreateResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationMcpPhoneCreateResponse : AopResponse
    {
        /// <summary>
        /// 话费业务订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 订单详情条转链接
        /// </summary>
        [XmlElement("order_jump_url")]
        public string OrderJumpUrl { get; set; }

        /// <summary>
        /// 千问订单信息
        /// </summary>
        [XmlElement("plain_text")]
        public QWOrderInfo PlainText { get; set; }

        /// <summary>
        /// AI付产品返回的预支付号，千问可根据此ID拉起收银台
        /// </summary>
        [XmlElement("pre_pay_id")]
        public string PrePayId { get; set; }
    }
}
