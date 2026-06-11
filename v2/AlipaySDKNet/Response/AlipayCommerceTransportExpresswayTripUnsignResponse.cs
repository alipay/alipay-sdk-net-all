using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripUnsignResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayTripUnsignResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车牌付代扣协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 解约申请受理状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }
    }
}
