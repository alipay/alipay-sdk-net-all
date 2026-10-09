using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountCreateResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 母户户名
        /// </summary>
        [XmlElement("bank_cert_name")]
        public string BankCertName { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [XmlElement("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 开户行行号
        /// </summary>
        [XmlElement("branch_no")]
        public string BranchNo { get; set; }

        /// <summary>
        /// 代发商户商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 响应收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }
    }
}
