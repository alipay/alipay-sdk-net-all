using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripSignResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswayTripSignResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车牌付代扣协议号，该协议号是经过车牌付业务域包装过的，只有该业务域能解析。
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 支付宝侧车牌付代扣签约申请订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
