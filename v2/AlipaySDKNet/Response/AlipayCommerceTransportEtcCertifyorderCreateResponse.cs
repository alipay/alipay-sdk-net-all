using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifyorderCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcCertifyorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝ETC申请单号,使用相同out_biz_no重复创建订单,返回相同订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// ETC平台扣款协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }
    }
}
