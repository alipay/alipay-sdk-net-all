using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseActivedorderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseActivedorderCreateResponse : AopResponse
    {
        /// <summary>
        /// ETC平台协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 支付宝ETC申请单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
