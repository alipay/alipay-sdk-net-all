using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountbalanceQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryAccountbalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 余额(单位为分)
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 响应的加签xml,通过base64编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
