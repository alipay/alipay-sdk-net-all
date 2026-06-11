using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportExpresswaySignQuerystatusResponse.
    /// </summary>
    public class AlipayCommerceTransportExpresswaySignQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车牌付代扣协议号，该协议号是经过车牌付业务域包装过的，只有该业务域能解析。
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 签约状态的描述
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 签约状态的枚举Code
        /// </summary>
        [XmlElement("sign_status_code")]
        public string SignStatusCode { get; set; }
    }
}
